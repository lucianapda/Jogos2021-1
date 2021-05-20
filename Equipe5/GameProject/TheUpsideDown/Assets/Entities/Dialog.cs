namespace Assets.Entities
{
    public class Dialog
    {
        public string CharacterName { get; protected set; }
        public string Text { get; protected set; }

        public Dialog(string characterName, string text)
        {
            CharacterName = characterName;
            Text = text;
        }
    }
}
