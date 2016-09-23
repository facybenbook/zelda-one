using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	namespace Actors
	{
		namespace Link
		{
			public class Walk : Actor{

				// Init the state
				public override void Start(){
					//this.getEntity().playDirectionalAnimation("Idle");
				}

				// Update is called once per frame
				public override void Update () {
					// Are we trying to move?
					float horizontal = Input.GetAxis("Horizontal");
					float vertical = Input.GetAxis("Vertical");
					if (horizontal == 0f && vertical == 0f) {
						this.getEntity().setState<Idle>();
						return;
					}

					// Are we attacking?
					if(Input.GetButtonDown("Attack")){
						this.getEntity().setState<Attack>();
					}

					// Set the direction
					this.getEntity().direction = Direction.fromFloats(horizontal, vertical);
					this.getEntity().playDirectionalAnimation("Walk");

					// Move link
					Vector3 input = new Vector3(horizontal, vertical, 0);
					this.getEntity().GetComponent<CharacterController> ().Move(input * Time.deltaTime);



				}
			}
		}
	}
}