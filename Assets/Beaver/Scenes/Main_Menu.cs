using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadPacManWorld()
    {
        SceneManager.LoadScene("Beaver");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
