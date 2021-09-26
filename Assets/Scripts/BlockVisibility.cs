using UnityEngine;

public class BlockVisibility : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Obstacle;
    public Transform Human;
    public Animator humanAnimator;

    public string[] humanAnimation;
   
    void Start()
    {
        int randomRotation = Random.Range(140, 210);

        Vector3 rot = Human.rotation.eulerAngles;
        rot = new Vector3(rot.x,rot.y+randomRotation,rot.z);

        Human.rotation = Quaternion.Euler(rot);

        int randomHumanIndex = Random.Range(0,humanAnimation.Length);
        for (int i = 0; i < humanAnimation.Length; i++)
        {
            if (randomHumanIndex == i)
            {
                string humanAnimationTrigger = humanAnimation[i];

                humanAnimator.SetTrigger(humanAnimationTrigger);
            }
        }

    }
    
    void Update() 
    {
        if (Obstacle.transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(Obstacle);
        }

        GameObject og = GameObject.Find("PlayerCat");
        GameObject mg = GameObject.Find("GameManager");
        float celebrateRef = og.GetComponent<PlayerCollision>().celebrateReference;
        float swimReference = mg.GetComponent<NewGameManager>().swimReference;

        if (celebrateRef > 0f)
        {
            humanAnimator.SetTrigger("HumanCelebrate");
        }

        if (swimReference > 0f)
        {
            humanAnimator.SetTrigger("HumanCelebrate");
        }
    }
}
