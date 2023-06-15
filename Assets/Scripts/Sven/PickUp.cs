using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject ItemToDespawn;
    public GameObject ItemToSpawn;
    public GameObject ItemPickedUpNoti;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //StartCoroutine(ItemOnAndOff());
            ItemToDespawn.SetActive(false);
            ItemToSpawn.SetActive(true);
        }
    }
    /*
    IEnumerator ItemOnAndOff()
    {
        ItemPickedUpNoti.SetActive(true);
        yield return new WaitForSeconds(4f);
        ItemPickedUpNoti.SetActive(false);
    }
    */
}
