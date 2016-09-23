using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	public abstract class Friendly : Actor{

		// Set the entity
		public void setEntity(Stage.Actors.Friendly entity){
			this.setEntity (entity);
		}

		// Return the entity of this state
		public Stage.Actors.Friendly getEntity(){
			return this.getEntity<Stage.Actors.Friendly> ();
		}

	}


}