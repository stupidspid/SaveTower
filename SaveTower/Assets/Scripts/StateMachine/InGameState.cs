using UnityEngine;
using Zenject;

namespace StateMachine
{
    public class InGameState : AbstractGameState
    {
        public InGameState(GameStateMachine gameStateMachine, SignalBus signalBus) : base(gameStateMachine, signalBus)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }
        public override void OnChangeStateRequest(RequestChangeStateSignal signal)
        {
            switch (signal.newStateType)
            {
                case StateType.Win:
                case StateType.Lose:
                    gameStateMachine.ChangeState(signal.newStateType);
                    break;
            }
        }
    }
}