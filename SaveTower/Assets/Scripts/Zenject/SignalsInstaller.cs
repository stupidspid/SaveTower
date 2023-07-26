namespace Zenject
{
    public class SignalsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            Container.DeclareSignal<GameStateChangedSignal>();
            Container.DeclareSignal<RequestChangeStateSignal>();
        }
    }
}