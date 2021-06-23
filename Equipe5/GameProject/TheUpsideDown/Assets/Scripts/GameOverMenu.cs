using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public GameObject MenuUI;
    public HealthBar HealthBar;

    private void Update()
    {
        if (HealthBar.CurrentHealth <= 0)
        {
            ShowMenu();
        }
    }

    public void HideMenu()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    private void ShowMenu()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        HideMenu();
        Loader.Reload();
    }
}
