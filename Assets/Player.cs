using UnityEngine;

//Player inherits monoBehaviour
public class Player : MonoBehaviour
{


    public float jumpHeight;
    //accessing the rigidbody property
    public Rigidbody rb;
    //start is used to initialize jumpHeight here
    void Start()
    {
        //start at 4 jump height
        jumpHeight = 4;
    }



    void Update()
    {
        //calls jump if space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(jumpHeight);
        }
    }
    //adds upward force to the player
    void Jump(float height)
    {
        //modifies the property
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, height, rb.linearVelocity.z);

    }



}

