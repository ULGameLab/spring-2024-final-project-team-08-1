using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowerClickLoader : MonoBehaviour
{
    public string targetScene = "CheatScene";  // Set this in the inspector to the name of the scene you want to load

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Detects a left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  // Sends out a ray from the camera to the mouse position
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100)) // Checks if the ray hits anything within 100 units
            {
                if (hit.collider.gameObject.CompareTag("Flower"))  // Check if the object hit has the tag "Flower"
                {
                    SceneManager.LoadScene(targetScene);  // Loads the specified scene
                }
            }
        }
    }
}
