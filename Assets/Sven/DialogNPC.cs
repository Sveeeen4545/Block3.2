using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNPC : BranchingDialogController
{
    //[SerializeField] private TextAssetValue dialogValue;
    [SerializeField] private TextAsset myDialog;
    //[SerializeField] private GameObject branchingCanvas;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Is colliding");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("tag collision is working");
            
                //Debug.Log("Input is working");
                //branchingCanvas.SetActive(true);
            EnableCanvas();
                dialogValue.value = myDialog;
            Cursor.lockState = CursorLockMode.None;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("tag collision is off");

            //Debug.Log("Input is off");
            //branchingCanvas.SetActive(false);
            DisableCanvas();
            dialogValue.value = myDialog;
            Cursor.lockState = CursorLockMode.Locked;


        }
    }
}
