using UnityEngine;
using System.Collections;
using StateMachine;
using System;


namespace Stage
{
	public class Entity : MonoBehaviour {
		// The current state
		protected State state;

		// Update is called once per frame
		public void Update () {
			// Update state?
			if (this.hasState ()) {
				this.getState ().Update ();
			}
		}

		/**
		 * Set the current state
		 * 
		 * @param State state
		 * @return void
		 */
		public void setState<T>() where T : State{
			this.state = ScriptableObject.CreateInstance<T> ();
			this.state.setEntity (this);
			this.state.Start ();
		}
			

		/**
		 * Return the current state
		 * 
		 * @return State
		 */
		public State getState(){
			return this.state;
		}

		/**
		 * Determine if we have a state
		 * 
		 * @return bool
		 */
		public bool hasState(){
			return this.state != null;
		}
	}
}
