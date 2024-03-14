using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        // Ensure the cursor is visible and not locked when on the main menu.
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Call this function to load the game scene.
    public void LoadGame()
    {
        SceneManager.LoadScene("Beaver"); // Replace with your actual game scene name if different.
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Call this function to load the game info scene.
    public void LoadGameInfo()
    {
        SceneManager.LoadScene("GameInfo"); // Load the scene that contains your game information.
        // Optionally, configure the cursor for the Game Info screen as needed.
    }

    // Call this function to load the credits scene.
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    // Call this function to load the game over scene.
    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    // Call this function to return to the main menu from other screens like game over or credits.
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("UI"); // Replace with your actual main menu scene name if different.
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Call this function to quit the game.
    public void QuitGame()
    {
        // The application will quit only when running outside the Unity editor.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
