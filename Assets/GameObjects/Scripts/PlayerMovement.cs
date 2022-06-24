using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forceUpdate = 2000f;
    public float sidewaysUpdate = 500f;
    public float jumpUpdate = 500f;
    private int noOfJump = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forceUpdate * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forceUpdate * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space"))
        {
            if(noOfJump == 0)
            {
                rb.AddForce(0, jumpUpdate * Time.deltaTime, 0, ForceMode.VelocityChange);
                noOfJump += 1;
            }
        }
        noOfJump = 0;
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysUpdate * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysUpdate * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < 0)
        {
            FindObjectOfType<GameManagement>().EndGame();
        }
    }
}
