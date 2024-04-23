using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableTrash : MonoBehaviour
{
    public string targetScene = "CheatScene"; 

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Flower"))  
        {
            Debug.Log("Flower clicked - Loading scene: " + targetScene);
            SceneManager.LoadScene(targetScene); 
        }
        else if (gameObject.CompareTag("Trash"))  
        {
            Debug.Log("Trash clicked - Destroying object: " + gameObject.name);
            GameStats.UpdateTrashCount();
            Destroy(gameObject); 
        }
    }
}
