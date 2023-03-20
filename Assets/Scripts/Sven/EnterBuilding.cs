using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuilding : MonoBehaviour
{
    public string buildingNameRoomEnter;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(buildingNameRoomEnter);
        }
    }




}
