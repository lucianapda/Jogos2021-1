using Assets.Utils.Attributes;

namespace Assets.Enums
{
    public enum WizardStates
    {
        [StringValue("isJump")]
        IsJump = 1,
        [StringValue("isRun")]
        IsRun,
        [StringValue("hurt")]
        Hurt,
        [StringValue("attack")]
        Attack,
        [StringValue("idle")]
        Idle,
        [StringValue("die")]
        Die
    }
}
