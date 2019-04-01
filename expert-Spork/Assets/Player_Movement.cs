using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidwaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // We marked this as "Fixed" Update because we
    // are using it to mess with physics
    // should use variables and check for pressed key in the update instead
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0);
        }
    }
}
