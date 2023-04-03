using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    private int waypointIndex;
    private Vector3 target;
    public List<Transform> waypoints2 = new List<Transform>();
    public List<Transform> specialEventWaypoints = new List<Transform>();
    public Transform audioQueNewTarget;
    //public bool isTriggerdQue = true;
    public bool specialEventTrigger = false;
    public bool specialEventTrigger2 = true;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
            //if(waypointIndex == 3 && isTriggerdQue)
            //{
            //    //AddAudioQueWaypoint();
            //    waypoints2.Add(audioQueNewTarget);
            //    isTriggerdQue = false;
            //}
            //if(waypointIndex == 2)
            //{
            //    waypoints2.Remove(audioQueNewTarget);
            //}
            
        }
        if (specialEventTrigger)
        {
            if (specialEventTrigger2)
            {
                specialEventTrigger2 = false;
                AddAudioQueWaypoint();
                //AddAndRemove();
            }
        }
    }

    void UpdateDestination()
    {
        if (specialEventTrigger)
        {
            Debug.Log(waypointIndex);
            target = specialEventWaypoints[waypointIndex].position;
        }
        else
        {
            target = waypoints2[waypointIndex].position;
        }
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints2.Count)
        {
            waypointIndex = 0;
        }
        if (waypointIndex == specialEventWaypoints.Count)
        {
            waypointIndex = 0;
        }
    }

    void AddAudioQueWaypoint()
    {
        specialEventWaypoints.Add(audioQueNewTarget);
    }

    IEnumerator AddAndRemove()
    {
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Waypoint"))
        {
            specialEventWaypoints.RemoveAt(0);
        }
    }

}
//list length != 0
