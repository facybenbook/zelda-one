using UnityEngine;
using System.Collections;
using StateMachine.Actors.Link;

namespace Stage
{
	namespace Actors
	{
		public class Link : Actor {
			public string name = "link";
			public int life = 10;

			// Use this for initialization
			void Start () {
				// Set default state
				this.setState<Idle>();
			}
		}
	}
}
