using System;
using StateMachine;
using UnityEngine;
using Zenject;

namespace UI
{
    public class GameStateCanvas : MonoBehaviour
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private StateType targetStateType;
        
        private SignalBus _signalBus;
        
        [Inject]
        private void Init(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }
        private void OnValidate()
        {
            if (canvas == null)
                canvas = GetComponentInChildren<Canvas>();
        }

        private void Awake()
        {
            _signalBus.Subscribe<GameStateChangedSignal>(ChangeCanvasVisibilityState);
        }

        private void OnDestroy()
        {
            _signalBus.Unsubscribe<GameStateChangedSignal>(ChangeCanvasVisibilityState);
        }

        private void ChangeCanvasVisibilityState(GameStateChangedSignal gameVisible)
        {
            canvas.gameObject.SetActive(gameVisible.currentGameStateType.ToString().Equals(targetStateType.ToString()));
        }
    }
}