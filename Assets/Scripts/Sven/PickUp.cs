using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject ItemToDespawn;
    public GameObject ItemToSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ItemToDespawn.SetActive(false);
            ItemToSpawn.SetActive(true);
        }
    }
}
