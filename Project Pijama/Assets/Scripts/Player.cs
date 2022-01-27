using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected float gravity;
    protected float speed;
    protected float strenght;

    Player(float gravity, float speed, float strenght)
    {
        this.gravity = gravity;
        this.speed = speed;
        this.strenght = strenght;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
