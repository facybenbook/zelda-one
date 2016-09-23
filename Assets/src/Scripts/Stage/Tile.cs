using UnityEngine;
using System.Collections;

namespace Stage
{
	public class Tile : Entity {

		// Use this for initialization
		void Start () {
			// Set default state
			this.setState<StateMachine.Tile>();
		}
	}
}