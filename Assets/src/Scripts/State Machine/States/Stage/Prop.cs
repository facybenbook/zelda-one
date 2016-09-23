using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	public class Prop : State{

		// Set the entity
		public void setEntity(Stage.Prop entity){
			this.setEntity (entity);
		}

		// Return the entity of this state
		public Stage.Prop getEntity(){
			return this.getEntity<Stage.Prop> ();
		}

	}


}