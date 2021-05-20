using Assets.Entities;
using Assets.Enums;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseScene : MonoBehaviour
{
    private Text _characterName;
    private Text _dialogText;

    protected readonly List<Dialog> Dialogs = new List<Dialog>();
    protected int CurrentDialog { get; private set; } = 0;
    public abstract GameScene NextScene { get; }
    public virtual bool LoadNextSceneWithoutLoadingScene { get; } = false;

    private void Awake()
    {
        _dialogText = transform.Find("DialogBox").transform.Find("DialogText").GetComponent<Text>();
        _characterName = transform.Find("DialogBox").transform.Find("CharacterName").GetComponent<Text>();
    }

    public abstract void ConfigureScene();

    private void Start()
    {
        ConfigureScene();

        ShowCurrentDialog();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ShowCurrentDialog();
    }

    private void ShowCurrentDialog()
    {
        if (CurrentDialog == Dialogs.Count)
        {
            Loader.Load(NextScene, LoadNextSceneWithoutLoadingScene);
        }
        else
        {
            Dialog dialog = Dialogs[CurrentDialog];

            _characterName.text = dialog.CharacterName;
            _dialogText.text = dialog.Text;
            CurrentDialog++;
        }
    }

    protected void AddDialog(string characterName, string dialogText)
        => Dialogs.Add(new Dialog(characterName, dialogText));
}
