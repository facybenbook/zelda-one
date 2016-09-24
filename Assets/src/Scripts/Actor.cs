using UnityEngine;
using System.Collections;
using Kusabi.StateMachine;
using Kusabi.Stage;
using Actors;

public class Actor : StateBehaviour {
    /// <summary>
    /// The direction this actor is facing
    /// </summary>
    public Direction direction = Direction.South;

    /// <summary>
    /// Return the actors name
    /// </summary>
    public string name = "Actor";

    /// <summary>
    /// Actor HP
    /// </summary>
    public Health health;

    




    /// <summary>
    /// Play a directional based animation
    /// </summary>
    /// <param name="name"></param>
    public void playDirectionalAnimation(string name)
    {
        name = name + "-" + DirectionSystem.getString(this.direction);
        GetComponent<Animator>().Play(name);
    }
}
