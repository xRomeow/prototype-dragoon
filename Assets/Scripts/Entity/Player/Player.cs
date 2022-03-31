using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private Vector2 currentInputVector;

    private void FixedUpdate()
    {
        MovePlayerWASD();
    }
    private void MovePlayerWASD()
    {
        Vector2 input = this.EntityControls.Player.Movement.ReadValue<Vector2>();
        Vector2 move = new Vector2(currentInputVector.x, currentInputVector.y);
        //current

        // 5f = speed
        this.MovePosition(move * 5f);
    }
}
