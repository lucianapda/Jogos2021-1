using Assets.Enums;
using Assets.Helpers;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private InputField UserNameInput;

    private readonly GameScene[] ValidScenes = new GameScene[]
    {
        GameScene.FirstScenario,
        GameScene.SecondScenario,
        GameScene.ThirdScenario,
        GameScene.EleventhScene
    };

    private void Awake()
    {
        UserNameInput = GameObject.Find("UserNameField").GetComponent<InputField>();
    }

    private void Start()
    {
        string playerName = PlayerPrefs.GetString(Constants.USER_NAME);

        if (!string.IsNullOrWhiteSpace(playerName))
        {
            UserNameInput.text = playerName.Trim();
        }
    }

    public void StartGame()
    {
        string playerName = UserNameInput.text?.Trim();

        if (!string.IsNullOrWhiteSpace(playerName))
        {
            CharactersNames.ProtagonistName = playerName;
        }

        PlayerPrefs.SetString(Constants.USER_NAME, CharactersNames.ProtagonistName);
        PlayerPrefs.Save();

        GameScene userLevel = (GameScene)PlayerPrefs.GetInt(Constants.USER_LEVEL);

        if (!ValidScenes.Contains(userLevel))
            userLevel = GameScene.FirstScenario;

        Loader.Load(userLevel);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
        UserNameInput.text = "Digite seu nome";
    }
}
