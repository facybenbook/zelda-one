using UnityEngine;
using System.Collections;

namespace Kusabi.Stage
{
    /// <summary>
    /// Manage a 2d topdown direction system
    /// </summary>
    public class DirectionSystem
    {
        /// <summary>
        /// Return the name of the direction
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string getString(Direction d)
        {
            switch (d)
            {
                case Direction.North: return "North"; break;
                case Direction.East: return "East"; break;
                case Direction.West: return "West"; break;
                default: return "South"; break;
            }
        }


        /// <summary>
        /// Return the vector of the direction
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Vector2 getVector(Direction d)
        {
            switch (d)
            {
                case Direction.North: return Vector2.up; break;
                case Direction.East: return Vector2.right; break;
                case Direction.West: return Vector2.left; break;
                default: return Vector2.down; break;
            }
        }

        /// <summary>
        /// Return a simple direction from a vector input
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Direction fromVector(Vector2 v, Direction current = Direction.South)
        {
            v = DirectionSystem.normalise(v);

            // Zero?
            if(v.magnitude <= 0.1f)
            {
                return current;
            }
            
            // East West?
            if(Mathf.Abs(v.x) > Mathf.Abs(v.y))
            {
                if(v.x > 0f)
                {
                    return Direction.East;
                }
                else
                {
                    return Direction.West;
                }
            }

            // North South?
            else if (Mathf.Abs(v.x) < Mathf.Abs(v.y))
            {
                if (v.y > 0f)
                {
                    return Direction.North;
                }
                else
                {
                    return Direction.South;
                }
            }

            // Default if matched
            else
            {
                v.y = 0;
                return DirectionSystem.fromVector(v);
            }
        }

        /// <summary>
        /// Return a vector2 nromalised in direction space.
        /// 1,0 | 0,1 | -1,0 | 0,-1 | 0,0
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector2 normalise(Vector2 v)
        {
            // Normalise the vector according to basiuc vector math
            v.Normalize();

            // Zero?
            if(v.magnitude < 0.1f)
            {
                return Vector2.zero;
            }

            // Possible directions
            Vector2[] compass = { Vector2.up, Vector2.right, Vector2.down, Vector2.left };

            // Some preperations
            float maxDot = -Mathf.Infinity;
            Vector2 ret = Vector2.zero;
            
            // Loop through all compass directions
            foreach(Vector2 com in compass)
            {
                // get the dot product
                float t = Vector2.Dot(v, com);

                // Closest?
                if(t > maxDot)
                {
                    ret = com;
                    maxDot = t;
                }
            }

            // return the direction
            return ret;

        }

    }
}