using UnityEngine;
using System.Collections;
using Kusabi.StateMachine;
using Actors;

namespace States.Link
{
    public class Idle : Kusabi.StateMachine.State
    {

        /// <summary>
        /// Entering the state
        /// </summary>
        public override void Enter()
        {
            this.getBehaviour<Actors.Link>().playDirectionalAnimation("Idle");
        }

        /// <summary>
        /// Leaving the state
        /// </summary>
        public override void Exit()
        {

        }


        /// <summary>
        /// Update the state
        /// </summary>
        public override void Update()
        {
            // Are we trying to move?
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            if (horizontal != 0f || vertical != 0f)
            {
                this.getBehaviour<Actors.Link>().setState<Walk>();
            }

            // Are we attacking?
            if (Input.GetButtonDown("Attack"))
            {
                this.getBehaviour<Actors.Link>().setState<Attack>();
            }
        }
    }
}
