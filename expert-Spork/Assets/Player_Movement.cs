using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

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
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
