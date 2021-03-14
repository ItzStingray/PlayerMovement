using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, moveSpeed);

        if(Input.GetKey("d"))
        {
            rb.AddForce(40, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-40, 0, 0);
        }
    }
}
