using UnityEngine;
using System.Collections;
using Stage;

namespace StateMachine
{
	public class Tile : State{

		// Set the entity
		public void setEntity(Stage.Tile entity){
			this.setEntity (entity);
		}

		// Return the entity of this state
		public Stage.Tile getEntity(){
			return this.getEntity<Stage.Tile> ();
		}

	}


}