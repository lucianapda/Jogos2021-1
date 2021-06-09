using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused { get; set; }

    public GameObject MenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    private void Pause()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt(Constants.USER_LEVEL, (int)Loader.CurrentScene);
        PlayerPrefs.Save();

        Resume();
    }

    public void MainMenu()
    {
        Resume();
        Loader.Load(Assets.Enums.GameScene.MainMenu);
    }
}
