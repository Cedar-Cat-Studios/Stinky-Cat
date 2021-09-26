using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 5f;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;

    public Transform playerCat;
	public Animator catAnimator;
    public Rigidbody rb;
    public ParticleSystem waterSpash;
    public ParticleSystem stinkyCat;
    public float minorDelay = 1f;
    private Vector3 splashTran;
    public float swimReference = 0f;

    private void Update() 
    {
        if (rb.position.y < -.5f)
		{
			catAnimator.SetTrigger("CatSwim");
            WaterSplash();
            enabled = false;
		}
    }

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameOver == false)
        {
            gameOver = true;

            Vector3 rot = playerCat.rotation.eulerAngles;
			rot = new Vector3(rot.x,rot.y+160,rot.z);

			playerCat.rotation = Quaternion.Euler(rot);

            if (rb.position.y < -1f)
            {
                swimReference = swimReference + 1f;
                catAnimator.SetTrigger("CatSwim");

                WaterSplash();

                stinkyCat.Stop();
                
                
            }

            else
            {
                catAnimator.SetTrigger("CatCaught");
            }

            Debug.Log("Game Over!");

            gameOverUI.SetActive(true);

            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart ()
    {
        SceneManager.LoadScene("Credits");
    }

    void WaterSplash()
    {
        splashTran = rb.transform.position;

        splashTran.y = splashTran.y + 2f;
        splashTran.z = splashTran.z + 5f;

        waterSpash.transform.position = splashTran;

        waterSpash.Emit (100);
    }
}
