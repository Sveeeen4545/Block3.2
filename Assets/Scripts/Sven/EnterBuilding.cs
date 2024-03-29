using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuilding : MonoBehaviour
{
    public string buildingNameRoomEnter;

    public Animator transition;

    public float transitionTime = 1.5f;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LoadLevel());
        }
    }


    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(buildingNameRoomEnter);

        yield return new WaitForSeconds(1f);
    }



}
