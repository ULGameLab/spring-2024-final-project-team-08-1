using UnityEngine;
using UnityEngine.AI;

public class AlligatorAI : MonoBehaviour
{
    public Transform playerTransform;
    public float detectionRadius = 10.0f;
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);
        if (distance < detectionRadius)
        {
            agent.SetDestination(playerTransform.position);
            animator.SetBool("isAttacking", true);
        }
        else
        {
            // Roaming logic here
            animator.SetBool("isAttacking", false);
        }
    }
}
