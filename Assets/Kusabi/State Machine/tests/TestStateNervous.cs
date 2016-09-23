using UnityEngine;
using System.Collections;

namespace Kusabi.StateMachine
{
    public class TestStateNervous : State
    {
        /// <summary>
        /// Entering the state
        /// </summary>
        public override void Enter()
        {
            Debug.Log("Nervous - entering");
        }

        /// <summary>
        /// Leaving the state
        /// </summary>
        public override void Exit()
        {
            Debug.Log("Nervous - leaving");
        }


        /// <summary>
        /// Update the state
        /// </summary>
        public override void Update()
        {
            Debug.Log("I'm so nervous");
            Debug.Log(this.getBehaviour<TestStateBehaviourUnique>().life);
            if(this.elapsed > 5f)
            {
                this.getBehaviour().setState<TestStateAngry>();
            }
        }
    }
}