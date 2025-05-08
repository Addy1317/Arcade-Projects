using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class Paddle : MonoBehaviour
    {
        [SerializeField] internal float speed = 10.0f;
        protected Rigidbody2D rigidbody2d;

        private void Awake()
        {
            rigidbody2d = GetComponent<Rigidbody2D>();
        }

        internal void ResetPosition()   
        {
            rigidbody2d.position = new Vector2(rigidbody2d.position.x, 0.0f);
            rigidbody2d.linearVelocity = Vector2.zero;
        }
    }
}