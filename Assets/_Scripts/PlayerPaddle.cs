using SlowpokeStudio.ArcadePong;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class PlayerPaddle : Paddle
    {
        private Vector2 _direction;

        private void Update()
        {
            PlayerPaddleControls();
        }

        private void FixedUpdate()
        {
            PlayerPaddleMagnitude();
        }

        private void PlayerPaddleControls()
        {
            if(Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
            {
                _direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.DownArrow))
            { 
                _direction = Vector2.down;
            }
            else
            {
                _direction = Vector2.zero;  
            }
        }

        private void PlayerPaddleMagnitude()
        {
            if (_direction.sqrMagnitude != 0)
            {
                rigidbody2d.AddForce(_direction * this.speed);
            }
        }
    }
}