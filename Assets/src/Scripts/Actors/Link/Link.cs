using UnityEngine;
using System.Collections;

namespace Actors
{
    public class Link : Actor
    {
        /// <summary>
        /// The GameObject to spawn when doing a sword blast
        /// </summary>
        public GameObject swordBlastPrefab;

        // Use this for initialization
        void Start()
        {
            // Set the default state
            this.setState<States.Link.Idle>();
        }

    }
}
