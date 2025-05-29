using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<GameStateManager>().AsSingle();
        Container.Bind<GameManager>().FromComponentInHierarchy().AsSingle();
    }
}