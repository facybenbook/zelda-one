using UnityEngine;
using System.Collections;

namespace Stage
{
	public class Prop : Entity {
		// The props name
		public string name = "";




		// Use this for initialization
		void Start () {
			// Set default state
			this.setState<StateMachine.Prop>();
		}

	}
}