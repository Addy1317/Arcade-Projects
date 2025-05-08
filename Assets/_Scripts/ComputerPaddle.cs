using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class ComputerPaddle : Paddle
    {
        [SerializeField] private Rigidbody2D _ballRigidbody2d;

        private void FixedUpdate()
        {
            TrackingBallMovement();
        }

        private void TrackingBallMovement()
        {
            if (this._ballRigidbody2d.linearVelocity.x > 0.0f)
            {
                if (this._ballRigidbody2d.position.y > this.transform.position.y)
                {
                    rigidbody2d.AddForce(Vector2.up * this.speed);
                }
                else if (this._ballRigidbody2d.position.y < this.transform.position.y)
                {
                    rigidbody2d.AddForce(Vector2.down * this.speed);
                }
            }
            else
            {
                if (this.transform.position.y > 0.0f)
                {
                    rigidbody2d.AddForce(Vector2.down * this.speed);
                }
                else if (this.transform.position.y < 0.0f)
                {
                    rigidbody2d.AddForce(Vector2.up * this.speed);
                }
            }
        }
    }
}
