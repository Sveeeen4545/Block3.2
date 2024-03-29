using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRacist : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    public AudioClip[] shoutingLines;
    [SerializeField] private int shoutIndex = 0;

    [Header ("How much lines there is to schout")]
    public int maxShouting = 2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator shoutingIntervalse()
    {
        Debug.Log("Works1");
        audioSource.clip = shoutingLines[shoutIndex];
        audioSource.Play();
        shoutIndex++;
        yield return new WaitForSeconds(2f);
        if (shoutingLines.Length < maxShouting)
        {
            shoutIndex = 0;
        }
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            shoutIndex = 0;
            StartCoroutine(shoutingIntervalse());
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            shoutIndex = 0;
            StopCoroutine(shoutingIntervalse());
        }
    }
}