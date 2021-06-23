using Assets.Entities;
using Assets.Enums;
using Assets.Helpers;
using Assets.Utils.Extensions;
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
    protected string ProtagonistName { get; private set; }
    protected string Cat { get; private set; }
    protected string InsecurityName { get; private set; }
    protected string LazzinessName { get; private set; }
    protected string AnxietyName { get; private set; }

    public abstract void ConfigureSceneDialog();

    private void Awake()
    {
        Protagonist = CharactersNames.Get(Character.Protagonist);
        Cat = CharactersNames.Get(Character.Cat);
        ProtagonistName = Protagonist.ToCamelCase();

        InsecurityName = CharactersNames.Get(Character.Insecurity).ToCamelCase();
        LazzinessName = CharactersNames.Get(Character.Lazziness).ToCamelCase();
        AnxietyName = CharactersNames.Get(Character.Anxiety).ToCamelCase();

        _dialogText = transform.Find("DialogBox").transform.Find("DialogText").GetComponent<Text>();
        _characterName = transform.Find("DialogBox").transform.Find("CharacterName").GetComponent<Text>();
    }

    private void Start()
    {
        ConfigureSceneDialog();

        ShowCurrentDialog();
    }

    private void Update()
    {
        if (!PauseMenu.Paused)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonUp(Constants.PRIMARY_BUTTON))
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

    protected void AddProtagonistDialog(string dialogText)
        => Dialogs.Add(new Dialog(Protagonist, dialogText));

    protected void AddCatDialog(string dialogText)
        => Dialogs.Add(new Dialog(Cat, dialogText));
}
