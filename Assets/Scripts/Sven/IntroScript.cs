using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(WaitForIntroToFinish());
    }

    IEnumerator WaitForIntroToFinish()
    {
        yield return new WaitForSeconds(36f);
        Debug.Log("Intro is working");
        SceneManager.LoadScene("InsideApartment1");
    }
}
