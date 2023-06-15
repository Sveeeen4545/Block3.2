using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneFromLibrary : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void RestartButton()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("ThorstenFromLibrary");
    }
}
