using UnityEngine;

public class FPSClickToPickup : MonoBehaviour
{
    public Camera fpsCamera; // Assign the FPS Camera in the inspector
    public float pickupDistance = 100f; // Maximum distance from which you can pick up trash

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            PickUpTrash();
        }
    }

    void PickUpTrash()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, pickupDistance))
        {
            if (hit.collider.CompareTag("Trash"))
            {
                // Perform your pickup logic here, e.g., incrementing a score or playing a sound
                Destroy(hit.collider.gameObject); // Example: Destroy the trash object
            }
        }
    }
}
