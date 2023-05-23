using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnTouch : MonoBehaviour
{
    DialogTesting dialogTesting;

    public GameObject DialogBox;
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            DialogBox.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogBox.SetActive(false);
        }
    }
}
