using Assets.Enums;
using Assets.Helpers;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    const string USER_NAME_INPUT_PLACEHOLDER = "Digite seu nome";
    private InputField UserNameInput;

    private readonly GameScene[] ValidScenes = new GameScene[]
    {
        GameScene.FirstScenario,
        GameScene.SecondScenario,
        GameScene.ThirdScenario,
        GameScene.FourthScenario,
        GameScene.FifthScene,
        GameScene.SixthScenario,
        GameScene.SeventhScene,
        GameScene.EighthScenario,
        GameScene.NinethScene,
        GameScene.TenthScenario,
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
            UserNameInput.text = playerName.Trim();
    }

    public void StartGame()
    {
        string playerName = UserNameInput.text?.Trim();

        if (!string.IsNullOrWhiteSpace(playerName) && !playerName.Equals(USER_NAME_INPUT_PLACEHOLDER))
            CharactersNames.ProtagonistName = playerName;

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
        UserNameInput.text = USER_NAME_INPUT_PLACEHOLDER;
        CharactersNames.ProtagonistName = string.Empty;
    }
}
