using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class BranchingDialogController : MonoBehaviour
{
    [SerializeField] public GameObject branchingCanvas;
    [SerializeField] public GameObject dialogPrefab;
    [SerializeField] public GameObject choicePrefab;
    [SerializeField] public TextAssetValue dialogValue;
    [SerializeField] public Story myStory;
    [SerializeField] public GameObject dialogHolder;
    [SerializeField] public GameObject choiceholder;
    [SerializeField] public ScrollRect dialogScroll;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableCanvas()
    {
        branchingCanvas.SetActive(true);
        SetStory();
        RefreshView();
        Cursor.lockState = CursorLockMode.None;

    }
    public void DisableCanvas()
    {
        branchingCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void SetStory()
    {
        if (dialogValue.value)
        {
            DeleteOldDialogs();
            myStory = new Story(dialogValue.value.text);
        }
        else
        {
            Debug.Log("Not story set");
        }
    }

    void DeleteOldDialogs()
    {
        for (int i = 0; i < dialogHolder.transform.childCount; i++)
        {
            Destroy(dialogHolder.transform.GetChild(i).gameObject);
        }
    }

    public void RefreshView()
    {
        while (myStory.canContinue)
        {
            MakeNewDialog(myStory.Continue());
        }
        if(myStory.currentChoices.Count > 0)
        {
            MakeNewChoices();
        }
        else
        {
            branchingCanvas.SetActive(false);
        }
        ScrollCo();
    }

    IEnumerator ScrollCo()
    {
        yield return null;
        dialogScroll.verticalNormalizedPosition = 0f;
    }

    void MakeNewDialog(string newDialog)
    {
        DialogObject newDialogObject = 
            Instantiate(dialogPrefab, dialogHolder.transform).GetComponent<DialogObject>();
        newDialogObject.Setup(newDialog);
    }

    void MakeNewResponse(string newDialog, int choiceValue)
    {
        ResponseObject newResponseObject =
            Instantiate(choicePrefab, choiceholder.transform).GetComponent<ResponseObject>();
        newResponseObject.Setup(newDialog, choiceValue);
        Button responseButton = newResponseObject.gameObject.GetComponent<Button>();
        if (responseButton)
        {
            responseButton.onClick.AddListener(delegate { ChooseChoise(choiceValue); });
        }
    }

    void MakeNewChoices()
    {
        for(int i = 0; i < choiceholder.transform.childCount; i++)
        {
            Destroy(choiceholder.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < myStory.currentChoices.Count; i++)
        {
            MakeNewResponse(myStory.currentChoices[i].text, i);
        }
    }

    public void ChooseChoise(int choice)
    {
        myStory.ChooseChoiceIndex(choice);
        RefreshView();
    }

}
