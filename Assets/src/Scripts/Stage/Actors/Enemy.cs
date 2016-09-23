using UnityEngine;
using System.Collections;

namespace Stage
{
	namespace Actors
	{
		public class Enemy : Actor {

			// Use this for initialization
			void Start () {
				// Set default state
				this.setState<StateMachine.Enemy>();
			}
		}
	}
}
