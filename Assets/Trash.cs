using UnityEngine;

public class ClickableTrash : MonoBehaviour
{
    void OnMouseDown()
    {
        // Perform your pickup logic here
        Destroy(gameObject); // Destroy the trash object upon clicking
    }
}
