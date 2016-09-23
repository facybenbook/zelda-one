using UnityEngine;
using System.Collections;

namespace Stage{
	public class Direction {
		// Return a direction from an input vector
		public static DirectionEnum fromVector(Vector2 v){
			return Direction.fromFloats (v.x, v.y);
		}

		// Return a direction from two floats (vertical and horizontal)
		public static DirectionEnum fromFloats(float x, float y){
			if (x > 0f) {
				if (Mathf.Abs (x) > Mathf.Abs (y)) {
					return DirectionEnum.East;
				} else {
					return y > 0f ? DirectionEnum.North : DirectionEnum.South;
				}
			} else if (x < 0f) {
				if (Mathf.Abs (x) > Mathf.Abs (y)) {
					return DirectionEnum.West;
				} else {
					return y > 0f ? DirectionEnum.North : DirectionEnum.South;
				}
			} else {
				if (Mathf.Abs (x) > Mathf.Abs (y)) {
					return DirectionEnum.East;
				} else {
					return y > 0f ? DirectionEnum.North : DirectionEnum.South;
				}
			}
			return DirectionEnum.South;
		}

		/**
		 * @description Converts the enum to a string
		 * @param DirectionEnum direction
		 * @return string
		 */
			public static string toString(DirectionEnum direction){
				switch (direction) {
				case DirectionEnum.West: return "West"; break;
				case DirectionEnum.North: return "North"; break;
				case DirectionEnum.South: return "South"; break;
				case DirectionEnum.East: return "East"; break;
				}
				return "South";
			}


		/**
		 * @description Converts the enum to an integer
		 * @param DirectionEnum direction
		 * @return int
		 */
		public static int toInt(DirectionEnum direction){
			switch (direction) {
			case DirectionEnum.West: return 4; break;
			case DirectionEnum.North: return 1; break;
			case DirectionEnum.South: return 3; break;
			case DirectionEnum.East: return 2; break;
			}
			return 3;
		}
	}

	public enum DirectionEnum{
		North, 
		East, 
		South, 
		West
	}
}
