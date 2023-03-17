using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerEnable : MonoBehaviour
{
    public GameObject menuScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            MouseDisable();
            Cursor.lockState = CursorLockMode.None;
            menuScreen.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MouseEnable();
            Cursor.lockState = CursorLockMode.Locked;
            menuScreen.SetActive(false);
        }
    }

    void MouseDisable()
    {
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
    }

    void MouseEnable()
    {
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
    }

}
