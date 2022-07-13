using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : AbstractBehavior
{

    public float jumpSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var canJump = inputState.GetButtonValue(inputButtons[0]);
        var holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

        if(collisionState.standing)
        {
            if (canJump && holdTime < 0.1f)
            {
                OnJump();
            }
        }
    }

    protected virtual void OnJump()
    {
        var vel = body2d.velocity;
        body2d.velocity = new Vector2(vel.x, jumpSpeed);
    }
}
