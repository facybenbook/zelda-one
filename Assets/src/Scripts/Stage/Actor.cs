using UnityEngine;
using System.Collections;

namespace Stage
{
	public class Actor : Entity {
		// The actors name
		public string name = "";

		// The actors life
		public int life = 10;

		// The direction this actor is facing
		public DirectionEnum direction;



		// Use this for initialization
		void Start () {
			// Set default state
			this.setState<StateMachine.Actor>();
			
		}


		/**
		 * Play an animation while accounting for the current direction
		 * 
		 * @param string name
		 */
		public void playDirectionalAnimation(string name){
			string dir = Direction.toString (this.direction);
			name = name + "-" + dir;
			this.GetComponent<Animator>().Play(name);
		}
	}
}
