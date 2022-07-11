using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior
{

    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);

        if (right || left)
        {
            var tempSpeed = speed;
            var velX = tempSpeed * (float)inputState.direction;

            body2d.velocity = new Vector2(velX, body2d.velocity.y);
        }
    }
}
