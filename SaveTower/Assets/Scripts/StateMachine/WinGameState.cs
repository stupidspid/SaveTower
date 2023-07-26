using UnityEngine;
using Zenject;

namespace StateMachine
{
    public class WinGameState : AbstractGameState
    {
        public WinGameState(GameStateMachine gameStateMachine, SignalBus signalBus) : base(gameStateMachine, signalBus)
        {
        }

        public override void Enter()
        {
            base.Enter();
            PlayerPrefs.SetInt(Constants.CURRENT_LEVEL, PlayerPrefs.GetInt(Constants.CURRENT_LEVEL) + 1);
            PlayerPrefs.SetInt(Constants.CURRENT_LEVEL_NAME, PlayerPrefs.GetInt(Constants.CURRENT_LEVEL_NAME) + 1);
        }
        
        public override void OnChangeStateRequest(RequestChangeStateSignal signal)
        {
            if (signal.newStateType == StateType.LoadLevel)
            {
                gameStateMachine.ChangeState(signal.newStateType);
            }
        }
    }
}