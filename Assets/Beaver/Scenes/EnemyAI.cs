using UnityEngine;
using UnityEngine.AI;

public class NutriaAI : MonoBehaviour
{
    public Transform scavengerTransform; // Assign in Inspector
    public float runAwayDistance = 10f;
    public float safeDistance = 20f;
    public float detectionRadius = 15f; // Distance to start running

    private NavMeshAgent agent;
    private Animator animator;
    private Vector3 spawnPosition;
    private bool isDead = false;

    private static readonly int RunHash = Animator.StringToHash("run");
    private static readonly int DieHash = Animator.StringToHash("die");

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        spawnPosition = transform.position;
    }

    void Update()
    {
        if (isDead) return; // Stop update logic if Nutria is "dead"

        float distanceToScavenger = Vector3.Distance(transform.position, scavengerTransform.position);

        // Run away logic
        if (distanceToScavenger < detectionRadius)
        {
            Vector3 directionToScavenger = transform.position - scavengerTransform.position;
            Vector3 runToPosition = transform.position + directionToScavenger.normalized * safeDistance;

            NavMeshHit hit;
            if (NavMesh.SamplePosition(runToPosition, out hit, safeDistance, NavMesh.AllAreas))
            {
                agent.SetDestination(hit.position);
            }
            animator.SetBool(RunHash, true);
        }
        else
        {
            animator.SetBool(RunHash, false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Scavenger") && !isDead)
        {
            isDead = true; // Mark as "dead"
            agent.isStopped = true; // Stop NavMeshAgent movement
            animator.SetTrigger(DieHash); // Play die animation
            Debug.Log("Nutria should play 'die' animation.");

            // Optional: Disable collider to avoid repeated triggers
            GetComponent<Collider>().enabled = false;

            // You can add a delay here and then call a respawn or destroy method
            // For example: Invoke(nameof(Respawn), 5f);
        }

        if (other.gameObject.CompareTag("Bullet")) 
        {
            Destroy(this.gameObject);
            GameStats.UpdateNutriaKilled();
        }
    }

    // Example respawn method
    void Respawn()
    {
        transform.position = spawnPosition; // Reset position
        isDead = false; // Reset death state
        agent.isStopped = false; // Allow movement again
        GetComponent<Collider>().enabled = true; // Re-enable collider
        animator.ResetTrigger(DieHash); // Reset animation trigger
        animator.Play("Idle"); // Assuming you have an idle animation to return to
    }
}
