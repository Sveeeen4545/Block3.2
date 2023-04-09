using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public string nextLevelName = "MainMenu";
    public float waitTime = 3f;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(nextLevelName);
    }

}
