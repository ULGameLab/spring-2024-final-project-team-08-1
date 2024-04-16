using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FPSController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Interaction Settings")]
    public Camera playerCamera;
    public LayerMask interactableLayer;
    public float interactionDistance = 2f;

    [Header("Level Management")]
    public string nextLevelScene = "NextLevel";

    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; // Player controls direction, not the NavMeshAgent
    }

    void Update()
    {
        HandleMovement();
        HandleInteraction();
        CheckForCheat();
    }

    private void HandleMovement()
    {
        // Calculate movement vector based on input
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection.Normalize();

        // Set the agent's velocity directly for smoother movement
        agent.velocity = moveDirection * moveSpeed;
    }

    private void HandleInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            // Using a sphere cast for better area coverage
            if (Physics.SphereCast(playerCamera.transform.position, 0.5f, playerCamera.transform.forward, out hit, interactionDistance, interactableLayer))
            {
                if (hit.collider.CompareTag("Trash"))
                {
                    Destroy(hit.collider.gameObject); // Destroy the object tagged as "Trash"
                }
            }
        }
    }

    private void CheckForCheat()
    {
        if (Input.GetKeyDown(KeyCode.C)) // Activate cheat to load next level
        {
            SceneManager.LoadScene(nextLevelScene);
        }
    }
}
