using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	public abstract class Enemy : Actor{

		// Set the entity
		public void setEntity(Stage.Actors.Enemy entity){
			this.setEntity(entity);
		}

		// Return the entity of this state
		public Stage.Actors.Enemy getEntity(){
			return this.getEntity<Stage.Actors.Enemy> ();
		}

	}


}