using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public NewGameManager gameManager;
    
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
