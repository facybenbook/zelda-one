using UnityEngine;
using System.Collections;
using Kusabi.StateMachine;
using Actors;
using Kusabi.Stage;

namespace States.SwordBlast
{
    public class Idle : Kusabi.StateMachine.State
    {

        /// <summary>
        /// Entering the state
        /// </summary>
        public override void Enter()
        {
            this.getBehaviour<Entities.SwordBlast>().playDirectionalAnimation("Sword");
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
            Entities.SwordBlast behaviour = this.getBehaviour<Entities.SwordBlast>();

            // Get the movement vector
            Vector2 movement = DirectionSystem.getVector(behaviour.direction) * behaviour.speed;

            // Move SwordBlast
            Vector3 input = new Vector3(movement.x, movement.y, 0);
            behaviour.transform.Translate(input * Time.deltaTime);
        }
    }
}
