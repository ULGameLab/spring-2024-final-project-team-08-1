using UnityEngine;
using UnityEngine.AI;

public class AlligatorAI : MonoBehaviour
{
    public Transform playerTransform;
    public float patrolRadius = 20f;
    public float patrolTimer = 10f;
    public float chaseDistance = 10f;
    public float chaseSpeed = 6f;

    private NavMeshAgent agent;
    private Animator animator;
    private float timer;

    private static readonly int IsWalkingHash = Animator.StringToHash("isWalking");

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        timer = patrolTimer;
    }

    void Update()
    {
        if (Vector3.Distance(playerTransform.position, transform.position) <= chaseDistance)
        {
            agent.SetDestination(playerTransform.position);
            agent.speed = chaseSpeed;
            animator.SetBool(IsWalkingHash, true);
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        timer += Time.deltaTime;

        if (timer >= patrolTimer)
        {
            Vector3 newDestination = RandomNavSphere(transform.position, patrolRadius, -1);
            agent.SetDestination(newDestination);
            timer = 0;
            animator.SetBool(IsWalkingHash, agent.velocity.magnitude > 0.1f);
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float distance, int layermask)
    {
        Vector3 randomDirection = Random.insideUnitSphere * distance;
        randomDirection += origin;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, distance, layermask);

        return navHit.position;
    }
}
