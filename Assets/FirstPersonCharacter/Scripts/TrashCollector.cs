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

    [Header("Audio Settings")]
    public AudioSource audioSource;  // Attach an AudioSource with the desired clip for the flower

    [Header("Level Management")]
    public string nextLevelScene = "CheatScene";

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
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection).normalized;
        agent.velocity = moveDirection * moveSpeed;
    }

    private void HandleInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.SphereCast(playerCamera.transform.position, 0.5f, playerCamera.transform.forward, out hit, interactionDistance, interactableLayer))
            {
                if (hit.collider.CompareTag("Trash"))
                {
                    Destroy(hit.collider.gameObject); // Destroy the object tagged as "Trash"
                }
                else if (hit.collider.CompareTag("Flower") && !audioSource.isPlaying)
                {
                    audioSource.Play(); // Play the audio when near a "Flower"
                }
            }
        }
    }

    private void CheckForCheat()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(nextLevelScene); // Load the next level
        }
    }
}
