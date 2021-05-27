using UnityEngine;
using UnityEngine.UI;
using System;
using Assets.Helpers;
public class MainMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        CharactersNames.ProtagonistName = GameObject.Find("UserNameField").GetComponent<InputField>().text;
        PlayerPrefs.SetString("UserName", CharactersNames.ProtagonistName);
        PlayerPrefs.Save();
        Loader.Load(Assets.Enums.GameScene.FirstScenario);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
