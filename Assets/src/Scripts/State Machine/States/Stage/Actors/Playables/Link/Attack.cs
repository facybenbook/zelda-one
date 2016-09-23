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
			public class Attack : Actor{

				// Init the state
				public override void Start(){
					this.getEntity().playDirectionalAnimation("Sword");
				}

				// Update is called once per frame
				public override void Update () {
					if (this.getStateTime () > 0.1f) {
						this.getEntity().setState<Idle>();
					}
				}
			}
		}
	}
}