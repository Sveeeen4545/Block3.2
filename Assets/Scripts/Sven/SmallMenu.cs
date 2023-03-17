using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMenu : MonoBehaviour
{
    public GameObject BookButton;
    public GameObject MenuButton;

    public GameObject BookPanel;
    public GameObject MenuPanel;

    public void EnableMenuPanel()
    {
        BookButton.SetActive(true);
        MenuButton.SetActive(false);
        BookPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    public void EnableBookPanel()
    {
        BookButton.SetActive(false);
        MenuButton.SetActive(true);
        BookPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

}
