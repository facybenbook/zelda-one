using UnityEngine;
using System.Collections;
using Kusabi.StateMachine;
using Actors;
using Kusabi.Stage;

namespace States.Link
{
    public class Walk : Kusabi.StateMachine.State
    {

        /// <summary>
        /// Entering the state
        /// </summary>
        public override void Enter()
        {

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
            Vector2 direction_input = DirectionSystem.normalise(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
            if (direction_input.magnitude <= 0.1f)
            {
                this.getBehaviour<Actors.Link>().setState<Idle>();
            }

            // Are we attacking?
            if (Input.GetButtonDown("Attack"))
            {
                this.getBehaviour<Actors.Link>().setState<Attack>();
            }

            // Set the direction
            this.getBehaviour<Actors.Link>().direction = DirectionSystem.fromVector(direction_input, this.getBehaviour<Actors.Link>().direction);
            this.getBehaviour<Actors.Link>().playDirectionalAnimation("Walk");

            // Move link
            Vector3 input = new Vector3(direction_input.x, direction_input.y, 0);
            this.getBehaviour<Actors.Link>().GetComponent<CharacterController>().Move(input * Time.deltaTime);
        }
    }
}
