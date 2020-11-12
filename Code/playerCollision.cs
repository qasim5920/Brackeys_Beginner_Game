using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
        }
    }
}
