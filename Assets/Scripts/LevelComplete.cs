using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //Instead we can load the next scene. Below just restarts the same level
        SceneManager.LoadScene("Credits");
    }
}

