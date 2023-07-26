using UnityEngine;
using Zenject;

namespace StateMachine
{
    public class MainMenuGameState : AbstractGameState
    {
        public MainMenuGameState(GameStateMachine gameStateMachine, SignalBus signalBus) : base(gameStateMachine, signalBus)
        {
        }
        public override void OnChangeStateRequest(RequestChangeStateSignal signal)
        {
            switch (signal.newStateType)
            {
                case StateType.Skins:
                case StateType.InGame:
                    gameStateMachine.ChangeState(signal.newStateType);
                    break;
            }
        }
    }
}