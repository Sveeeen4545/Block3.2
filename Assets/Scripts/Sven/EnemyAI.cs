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
    public Transform audioQueNewTarget;
    public bool isTriggerdQue = true;


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
            if(waypointIndex == 3 && isTriggerdQue)
            {
                //AddAudioQueWaypoint();
                waypoints2.Add(audioQueNewTarget);
                isTriggerdQue = false;
            }
            if(waypointIndex == 2)
            {
                waypoints2.Remove(audioQueNewTarget);
            }
        }
    }

    void UpdateDestination()
    {
        target = waypoints2[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints2.Count)
        {
            waypointIndex = 0;
        }
    }
    void AddAudioQueWaypoint()
    {
        waypoints2.Add(audioQueNewTarget);
    }

}
