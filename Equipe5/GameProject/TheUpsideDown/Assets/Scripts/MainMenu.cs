using Assets.Helpers;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        string playerName = PlayerPrefs.GetString(Constants.USER_NAME);

        if (!string.IsNullOrWhiteSpace(playerName))
        {
            GameObject.Find("UserNameField").GetComponent<InputField>().text = playerName.Trim();
        }

    }

    public void StartGame()
    {
        string playerName = GameObject.Find("UserNameField").GetComponent<InputField>().text?.Trim();

        if (!string.IsNullOrWhiteSpace(playerName))
        {
            CharactersNames.ProtagonistName = playerName;
        }

        PlayerPrefs.SetString(Constants.USER_NAME, CharactersNames.ProtagonistName);
        PlayerPrefs.Save();

        Loader.Load(Assets.Enums.GameScene.FirstScenario);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
