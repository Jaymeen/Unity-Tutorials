using FrankenBit.Utilities;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.States.IntroStates
{
    public class IntroStateMachineRunner : MonoBehaviour
    {
        StateMachine _machine = new StateMachine();

        [Inject]
        public void Setup()
        {
            
        }
    }
}
