using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 100f;
    public GameObject canvas;
    public PlayerMovement movement;
    public ParticleSystem deathExplosion;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, moveSpeed);

        if (Input.GetKey("d"))
        {
            rb.AddForce(400, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-400, 0, 0);
        }

        if (Input.GetButton("Horizontal"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
    }



    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            canvas.SetActive(true);
            movement.enabled = false;
            deathExplosion.Play();
        }

        if (collisionInfo.collider.name == "TheVoid")
        {
            canvas.SetActive(true);
            movement.enabled = false;
        }
    }
}
