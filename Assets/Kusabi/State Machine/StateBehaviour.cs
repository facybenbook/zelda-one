using UnityEngine;
using System.Collections;
using System;

namespace Kusabi.StateMachine
{
    /// <summary>
    /// The state behaviour is an extension of Unity's MonoBehaviour but with more emphasis on utilising States.
    /// It has a single current state as well as methods for switching states.
    /// 
    /// It will send messages to the state much the same way Unity sends messages to the MonoBehaviour
    /// </summary>
    public class StateBehaviour : MonoBehaviour
    {
        /// <summary>
        /// The current state
        /// </summary>
        protected State state;

        /// <summary>
        /// Set the current state
        /// </summary>
        public void setState<T>() where T : State
        {
            // Close last state (if found)
            if (this.hasState())
            {
                this.state.Exit();
                Destroy(this.state);
            }

            // Create and store a new instance of this state
            this.state = ScriptableObject.CreateInstance<T>();
            this.state.setBehaviour(this);

            // Run the awake method
            this.state.Start();
            this.state.Enter();

        }

        /// <summary>
        /// Return the current state
        /// </summary>
        /// <returns></returns>
        public State getState()
        {
            return this.state;
        }

        /// <summary>
        /// Do we currently have an active state?
        /// </summary>
        /// <returns></returns>
        public bool hasState()
        {
            return this.state != null;
        }


        /// <summary>
        /// Call the update method on the current state.
        /// </summary>
        void Update()
        {
            if (this.hasState())
            {
                this.getState().Update();
            }
        }
    }
}
