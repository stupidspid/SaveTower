using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace StateMachine
{
    public class LoadLevelGameState : AbstractGameState
    {
        public LoadLevelGameState(GameStateMachine gameStateMachine, SignalBus signalBus) : base(gameStateMachine, signalBus)
        {
        }

        public override void Enter()
        {
            base.Enter();
            var operation = SceneManager.LoadSceneAsync(0);
            operation.allowSceneActivation = true;
            operation.completed += StartLevel;
            
        }

        private void StartLevel(AsyncOperation obj)
        {
            gameStateMachine.ChangeState(StateType.MainMenu);
        }
    }
}