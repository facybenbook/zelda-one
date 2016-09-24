using UnityEngine;
using System.Collections;

namespace Actors
{
    [System.Serializable]
    public class Health
    {
        /// <summary>
        /// Max Health
        /// </summary>
        public float max = 10f;

        /// <summary>
        /// Current Health
        /// </summary>
        public float current = 10f;


        /// <summary>
        /// Return if the life is full
        /// </summary>
        /// <returns></returns>
        public bool full()
        {
            return current >= max;
        }
    }
}
