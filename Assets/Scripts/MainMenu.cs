using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Beaver");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LoadCheatScene()
    {
        SceneManager.LoadScene("CheatScene");
    }


    public void LoadGameInfo()
    {
        SceneManager.LoadScene("GameInfo");
    }

    public void LoadNative()
    {
        SceneManager.LoadScene("DemoGrassFlowers");
    }

    public void LoadPractice()
    {
        SceneManager.LoadScene("Practice");
    }

    public void LoadSwampDemo()
    {
        SceneManager.LoadScene("Beaverdemo");
    }

    public void LoadSecondLevel()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("SecondLevel");
=======
        SceneManager.LoadScene("SecondLeveldemo");
>>>>>>> origin/kelly
    }

    public void LoadTrashLevel()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("Trash");
    }

    public void LoadTrashLeveldemo()
    {
=======
>>>>>>> origin/kelly
        SceneManager.LoadScene("Trashdemo");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadDemo()
    {
        SceneManager.LoadScene("Demo");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("UI");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
