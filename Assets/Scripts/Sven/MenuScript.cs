using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuScript : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject MenuPanel;

    public GameObject pauseFirstButton, optionsFirstButton, optionsCloseButton;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("InsideApartment");
    }

    public void SettingsPanelEnable()
    {
        SettingsPanel.SetActive(true);
        MenuPanel.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);
    }

    public void SettingsPanelDisable()
    {
        SettingsPanel.SetActive(false);
        MenuPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsCloseButton);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
