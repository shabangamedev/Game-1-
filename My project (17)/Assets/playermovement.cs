using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardforce =200f;
    public float sideforce = 100f;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, Forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y<-2)
        { 
           FindAnyObjectByType<GameManager>().EndGame();
        }
        
    }
}
