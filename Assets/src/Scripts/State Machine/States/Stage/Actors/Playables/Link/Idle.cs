using UnityEngine;
using System.Collections;
using Stage.Actors;
using Stage;

namespace StateMachine
{
	namespace Actors
	{
		namespace Link
		{
			public class Idle : Actor{

				// Init the state
				public override void Start(){
					// Start the animation
					this.getEntity().playDirectionalAnimation("Idle");
				}

				// Update is called once per frame
				public override void Update () {
					
					// Are we trying to move?
					float horizontal = Input.GetAxis("Horizontal");
					float vertical = Input.GetAxis("Vertical");
					if (horizontal != 0f || vertical != 0f) {
						this.getEntity().setState<Walk>();
					}

					// Are we attacking?
					if(Input.GetButtonDown("Attack")){
						this.getEntity().setState<Attack>();
					}
				}
			}
		}
	}
}