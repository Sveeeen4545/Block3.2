using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject MenuPanel;

    public void PlayButton()
    {
        SceneManager.LoadScene("ThorstenOne");
    }

    public void SettingsPanelEnable()
    {
        SettingsPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

    public void SettingsPanelDisable()
    {
        SettingsPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
