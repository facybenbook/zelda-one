using UnityEngine;
using System.Collections;

namespace Kusabi.StateMachine
{
    public class TestStateBehaviourUnique : StateBehaviour
    {
        public float life = 10f;

        // Use this for initialization
        void Start()
        {
            this.setState<TestStateNervous>();
        }

        
    }
}