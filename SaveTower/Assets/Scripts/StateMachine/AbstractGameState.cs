using Zenject;

namespace StateMachine
{
    public abstract class AbstractGameState
    {
        protected SignalBus signalBus;
        protected GameStateMachine gameStateMachine;
        public AbstractGameState(GameStateMachine gameStateMachine, SignalBus signalBus)
        {
            this.signalBus = signalBus;
            this.gameStateMachine = gameStateMachine;
        }

        public virtual void Enter()
        {
            signalBus.Subscribe<RequestChangeStateSignal>(OnChangeStateRequest);
        }

        public virtual void Exit()
        {
            signalBus.Unsubscribe<RequestChangeStateSignal>(OnChangeStateRequest);
        }

        public virtual void OnChangeStateRequest(RequestChangeStateSignal signal) { }
    }

    public enum StateType
    {
        None = 0,
        MainMenu = 1,
        Skins = 2,
        InGame = 3,
        Lose = 4,
        Win = 5,
        LoadLevel = 6,
    }
}