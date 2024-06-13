using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float torque;
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("d")|| Input.GetKey("right"))
        {
            if(rb.position.x < 9)
                rb.AddForce(torque, 0, 0);
        }
        if (Input.GetKey(("a")) || Input.GetKey("left"))
        {
            if (rb.position.x > -9)
                rb.AddForce(-torque, 0, 0);
        }

        if (Input.GetKey("space") || Input.GetKey("up"))
        {
            rb.AddForce(0, 200, 0);
        }
        switch (rb.position.x)
        {
            case >= 8:
            case <= -8:
            {
                var vec = rb.velocity;
                vec.x = 0;
                rb.velocity = vec;
                break;
            }
        }

    }
}
