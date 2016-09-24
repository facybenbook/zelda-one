using UnityEngine;
using System.Collections;

namespace Entities
{
    public class SwordBlast : Entity
    {
        /// <summary>
        /// The speed to move at
        /// </summary>
        public float speed = 0.5f;

        // Use this for initialization
        void Start()
        {
            // Set the default state
            this.setState<States.SwordBlast.Idle>();
        }

    }
}