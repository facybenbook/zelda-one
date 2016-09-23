using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	public abstract class Playable : Actor{

		// Set the entity
		public void setEntity(Stage.Actors.Playable entity){
			this.setEntity (entity);
		}

		// Return the entity of this state
		public Stage.Actors.Playable getEntity(){
			return this.getEntity<Stage.Actors.Playable> ();
		}

	}


}