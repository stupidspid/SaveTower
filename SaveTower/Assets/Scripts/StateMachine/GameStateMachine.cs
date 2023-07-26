using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace StateMachine
{
    public class GameStateMachine : MonoBehaviour
    {
        private Dictionary<StateType, AbstractGameState> states;
        private AbstractGameState currentGameState;
        private SignalBus signalBus;

        [Inject]
        private void Init(SignalBus signalBus)
        {
            this.signalBus = signalBus;
        }
        private void Awake()
        {
            states = new Dictionary<StateType, AbstractGameState>()
            {
                {StateType.MainMenu, new MainMenuGameState(this, signalBus)},
                {StateType.Lose, new LoseGameState(this, signalBus)},
                {StateType.Skins, new SkinsGameState(this, signalBus)},
                {StateType.Win, new WinGameState(this, signalBus)},
                {StateType.InGame, new InGameState(this, signalBus)},
                {StateType.LoadLevel, new LoadLevelGameState(this, signalBus)},
            };

            if (!PlayerPrefs.HasKey(Constants.CURRENT_LEVEL))
            {
                PlayerPrefs.SetInt(Constants.CURRENT_LEVEL, 1);
            }
        }

        private void Start()
        {
            ChangeState(StateType.LoadLevel);
        }

        public void ChangeState(StateType newStateType)
        {
            if(currentGameState!=null)
                currentGameState.Exit();

            currentGameState = states[newStateType];
            currentGameState.Enter();

            signalBus.Fire(new GameStateChangedSignal(newStateType));
        }
    }
}