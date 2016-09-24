using UnityEngine;
using System.Collections;
using Kusabi.StateMachine;
using Actors;

namespace States.Link
{
    public class Attack : State
    {
        /// <summary>
        /// Store the reference to link once
        /// </summary>
        Actors.Link link;

        /// <summary>
        /// Entering the state
        /// </summary>
        public override void Enter()
        {
            // Get the reference to to link
            link = this.getBehaviour<Actors.Link>();

            // Set the animation
            link.playDirectionalAnimation("Sword");

            // Spawn a sword blast?
            if (link.health.full() && link.swordBlastPrefab != null)
            {
                // Spawn the blast
                GameObject swordblast = GameObject.Instantiate(link.swordBlastPrefab, link.transform.position, link.transform.rotation) as GameObject;
                Entity sb = swordblast.GetComponent<StateBehaviour>() as Entity;
                sb.direction = link.direction;
            }
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
            Actors.Link link = this.getBehaviour<Actors.Link>();

            // Go back to the idle state after a short time
            if (this.elapsed > 0.1f)
            {
                link.setState<Idle>();
            }
        }
    }
}
