using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(Creditss());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Creditss()
    {
        yield return new WaitForSeconds(105f);
        SceneManager.LoadScene("MainMenu");
    }

}
