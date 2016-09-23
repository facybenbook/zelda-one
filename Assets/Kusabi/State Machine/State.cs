using UnityEngine;
using System.Collections;
using System;

namespace Kusabi.StateMachine
{
    public class State : ScriptableObject
    {
        /// <summary>
        /// The behaviour that is running this state
        /// </summary>
        protected StateBehaviour behaviour;

        /// <summary>
        /// The time this state was started
        /// </summary>
        public float started_at;

        /// <summary>
        /// Initialise this state
        /// </summary>
        public void Start()
        {
            this.started_at = Time.time;
        }

        /// <summary>
        /// The length of time that has elapsed in this state
        /// </summary>
        /// <returns></returns>
        public float elapsed
        {
            get
            {
                return Time.time - this.started_at;
            }            
        }
        
        /// <summary>
        /// Set the behaviour that is running the state
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void setBehaviour(StateBehaviour behaviour)
        {
            this.behaviour = behaviour;
        }

        /// <summary>
        /// Return the behaviour that runs this state
        /// </summary>
        /// <returns></returns>
        public StateBehaviour getBehaviour()
        {
            return this.behaviour;
        }

        /// <summary>
        /// Return the behaviour that runs this state
        /// </summary>
        /// <returns></returns>
        public T getBehaviour<T>() where T : StateBehaviour
        {
            return this.behaviour as T;
        }

        /// <summary>
        /// Called when entering the state
        /// </summary>
        public virtual void Enter()
        {

        }

        /// <summary>
        /// Called when leaving the state
        /// </summary>
        public virtual void Exit()
        {

        }

        /// <summary>
        /// The update method
        /// </summary>
        public virtual void Update()
        {

        }
    }
}
