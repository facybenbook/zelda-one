using UnityEngine;
using System.Collections;

namespace Kusabi.StateMachine
{
    public class TestStateAngry : State
    {
        /// <summary>
        /// Entering the state
        /// </summary>
        public override void Enter()
        {
            Debug.Log("Angry - entering");
        }

        /// <summary>
        /// Leaving the state
        /// </summary>
        public override void Exit()
        {
            Debug.Log("Angry - leaving");
        }


        /// <summary>
        /// Update the state
        /// </summary>
        public override void Update()
        {
            Debug.Log("I'm so angry!!!!");
            if (this.elapsed > 5f)
            {
                this.getBehaviour().setState<TestStateNervous>();
            }
        }
    }
}
