using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResponseObject : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI myTest;
    private int choiceValue;

    public void Setup(string newDialog, int myChoise)
    {
        myTest.text = newDialog;
        choiceValue = myChoise;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
