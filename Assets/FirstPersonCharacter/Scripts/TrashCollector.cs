using UnityEngine;
using UnityEngine.AI;

public class FPSController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera playerCamera;
    public LayerMask interactableLayer; // Set this in the inspector to the layer your trash objects are on.

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        MovePlayer();
        InteractWithObjects();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            agent.Move(transform.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            agent.Move(-transform.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            agent.Move(-transform.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            agent.Move(transform.right * moveSpeed * Time.deltaTime);
        }
    }

    void InteractWithObjects()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, 2f, interactableLayer))
            {
                if (hit.collider.CompareTag("Trash"))
                {
                    // Implement the logic for picking up trash or interacting with objects here.
                    Destroy(hit.collider.gameObject); // Example: just destroy the trash object
                }
            }
        }
    }
}
