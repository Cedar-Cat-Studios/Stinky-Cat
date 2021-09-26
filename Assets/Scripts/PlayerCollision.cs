using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Animator catAnimator;
    public Rigidbody rb;
    public ParticleSystem stinkyCat;
    public float celebrateReference = 0f;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            celebrateReference = celebrateReference + 1f;
            movement.enabled = false;
            Debug.Log("The block hit an obstacle!");

            catAnimator.SetTrigger("CatCaught");

            stinkyCat.Stop();

            FindObjectOfType<NewGameManager>().EndGame();
        }
        
    }
}
