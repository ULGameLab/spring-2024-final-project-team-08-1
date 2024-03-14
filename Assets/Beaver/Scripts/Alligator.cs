using UnityEngine;
using UnityEngine.AI;

public class AlligatorAI : MonoBehaviour
{
    public Transform[] waypoints;
    private int waypointIndex = 0;
    private NavMeshAgent agent;

    public float chaseDistance = 10f; // Distance within which to start chasing the Scavenger
    private Transform scavengerTransform; // To dynamically find and assign the Scavenger

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GoToNextWaypoint();
        // Find and assign the Scavenger transform at runtime
        scavengerTransform = GameObject.Find("Scavenger").transform;
    }

    void GoToNextWaypoint()
    {
        if (waypoints.Length == 0) return;
        agent.destination = waypoints[waypointIndex].position;
        waypointIndex = (waypointIndex + 1) % waypoints.Length;
    }

    void Update()
    {
        // Patrol between waypoints
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextWaypoint();
        }

        if (scavengerTransform != null)
        {
            float distanceToScavenger = Vector3.Distance(scavengerTransform.position, transform.position);

            // Start chasing the Scavenger if they're within chaseDistance
            if (distanceToScavenger <= chaseDistance)
            {
                agent.destination = scavengerTransform.position;
            }
            else if (distanceToScavenger > chaseDistance && waypointIndex != 0)
            {
                // Return to patrolling if the Scavenger is far away
                GoToNextWaypoint();
            }
        }
    }
}
