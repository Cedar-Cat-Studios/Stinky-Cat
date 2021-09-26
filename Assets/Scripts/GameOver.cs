using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
        public void RestartLevel()
    {
        //Instead we can load the next scene. Below just restarts the same level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
