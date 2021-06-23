public abstract class FigthScene : BaseScene
{
    protected abstract bool ShouldChangeScene();

    void Update()
    {
        if (ShouldChangeScene())
            ChangeScene();
    }
}
