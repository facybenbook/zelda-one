using UnityEngine;
using System.Collections;

namespace Kusabi.StateMachine
{
    public class TestStateBehaviour : StateBehaviour
    {

        // Use this for initialization
        void Start()
        {
            this.setState<TestStateNervous>();
        }





    }
}