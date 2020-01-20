using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    
    public float forwadForce = 2000f;

    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
         rb.AddForce(0, 0, forwadForce * Time.deltaTime);

         if ( Input.GetKey("right") )
         {
             rb.AddForce(sidewaysForce * Time.deltaTime, 0,  0, ForceMode.VelocityChange);
         }

         if ( Input.GetKey("left") )
         {
             rb.AddForce(-sidewaysForce * Time.deltaTime, 0,  0, ForceMode.VelocityChange);
         }
         if (rb.position.y < -1f) 
         {
             FindObjectOfType<GameManager>().EndGame();
         }
    }
}
