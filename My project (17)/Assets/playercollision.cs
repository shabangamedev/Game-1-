
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;// Start is called before the first frame update
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
            
        }
    }

    
}
