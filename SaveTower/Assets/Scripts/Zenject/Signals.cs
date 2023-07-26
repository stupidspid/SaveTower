using System.Collections.Generic;
using Cinemachine;
using StateMachine;
using UnityEngine;

namespace Zenject
{
    public class GameStateChangedSignal
    {
        public StateType currentGameStateType;
        public int levelNum;

        public GameStateChangedSignal(StateType stateType)
        {
            currentGameStateType = stateType;
        }
        public GameStateChangedSignal(StateType stateType, int levelNum)
        {
            currentGameStateType = stateType;
            this.levelNum = levelNum;
        }
    }

    public class RequestChangeStateSignal
    {
        public StateType newStateType;
        public RequestChangeStateSignal(StateType stateType)
        {
            newStateType = stateType;
        }
    }
}