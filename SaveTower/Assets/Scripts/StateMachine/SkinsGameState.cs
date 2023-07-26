using Zenject;

namespace StateMachine
{
    public class SkinsGameState : AbstractGameState
    {
        public SkinsGameState(GameStateMachine gameStateMachine, SignalBus signalBus) : base(gameStateMachine, signalBus)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void OnChangeStateRequest(RequestChangeStateSignal signal)
        {
            if (signal.newStateType == StateType.MainMenu)
            {
                gameStateMachine.ChangeState(signal.newStateType);
            }
        }
    }
}