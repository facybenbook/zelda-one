using UnityEngine;
using System.Collections;
using Stage;
using System;

namespace StateMachine
{
	public class State : ScriptableObject{
		// The entity using this state
		protected Entity entity;

		// The type of entity this state controlls
		protected Type entityType;

		// Time we entered the state
		protected float startTime = 0f;

		// Constructor
		public State(){
			this.enterState ();
		}

		// Called once when setting the state
		public virtual void Start (){}

		// Update is called once per frame
		public virtual void Update (){}

		// Set the entity
		public virtual void setEntity(Entity entity){
			this.entity = entity;
		}

		// Return the entity of this state
		public virtual T getEntity<T>() where T: Entity{
			return this.entity as T;
		}

		// Return the entity of this state
		public bool hasEntity(){
			return this.entity != null;
		}

		// Call in constructor to init the state
		public void enterState(){
			this.startTime = Time.time;
		}

		// Return the length of time we have been in this state
		public float getStateTime(){
			return Time.time - this.startTime;
		}


	}
}