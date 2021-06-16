using Assets.Entities;
using Assets.Enums;
using Assets.Helpers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class DialogScene : BaseScene
{
    private Text _characterName;
    private Text _dialogText;

    protected readonly List<Dialog> Dialogs = new List<Dialog>();
    protected int CurrentDialog { get; private set; } = 0;

    protected string Protagonist { get; private set; }

    private void Awake()
    {
        Protagonist = CharactersNames.Get(Character.Protagonist);
        _dialogText = transform.Find("DialogBox").transform.Find("DialogText").GetComponent<Text>();
        _characterName = transform.Find("DialogBox").transform.Find("CharacterName").GetComponent<Text>();
    }

    private void Start()
    {
        ConfigureScene();

        ShowCurrentDialog();
    }

    private void Update()
    {
        if (!PauseMenu.Paused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ShowCurrentDialog();
        }
    }

    private void ShowCurrentDialog()
    {
        if (CurrentDialog == Dialogs.Count)
        {
            ChangeScene();
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

    protected void AddContextDialog(string dialogText)
        => Dialogs.Add(new Dialog(string.Empty, dialogText));
}
