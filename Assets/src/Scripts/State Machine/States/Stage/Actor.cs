using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	public class Actor : State{

		// Set the entity
		public void setEntity(Stage.Actor entity){
			this.setEntity(entity);
		}

		// Return the entity of this state
		public Stage.Actor getEntity(){
			return this.getEntity<Stage.Actor> ();
		}

	}


}