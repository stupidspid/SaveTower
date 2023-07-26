using StateMachine;
using UnityEngine;
using Zenject;

namespace UI
{
    public class ChangeGameState : MonoBehaviour
    {
        [SerializeField] protected StateType stateType;
        protected SignalBus signalBus;

        [Inject]
        private void Init(SignalBus signalBus)
        {
            this.signalBus = signalBus;
        }

        protected void ChangeState()
        {
            signalBus.Fire(new RequestChangeStateSignal(stateType));
        }
    }
}