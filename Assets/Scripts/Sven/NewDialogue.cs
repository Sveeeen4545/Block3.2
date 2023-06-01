using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public static NewDialogue Instance;
    [SerializeField]  private int index;
    public GameObject UIPanelForDialogue;
    [SerializeField] private AudioSource audioPlayer;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        audioPlayer.GetComponent <AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Check"))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        textComponent.text = string.Empty;
        index = 0;
        UIPanelForDialogue.SetActive(true);
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            audioPlayer.Play();
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void HideDialogue()
    {
        UIPanelForDialogue.SetActive(false);
        StopAllCoroutines();
        //gameObject.SetActive(false);
        index = 0;
        textComponent.text = string.Empty;
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            UIPanelForDialogue.SetActive(false);
        }
    }
}