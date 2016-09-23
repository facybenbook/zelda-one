﻿using UnityEngine;
using System.Collections;
using StateMachine.Actors.Link;

namespace Stage
{
	namespace Actors
	{
		public class Playable : Actor {

			// Use this for initialization
			void Start () {
				// Set default state
				this.setState<StateMachine.Playable>();
			}
		}
	}
}