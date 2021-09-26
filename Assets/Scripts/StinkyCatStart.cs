using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StinkyCatStart : MonoBehaviour
{
    public Animator catAnimator;
    public float switchDelay = 10f;
    public float minorDelay = 5f;

    void Start()
    {
        Invoke("Lick", switchDelay);
    }

    // void Update()
    // {
        
    // }

    void Lick()
    {
        catAnimator.SetTrigger("CatLick");
        Invoke("Caress", minorDelay);
    }
    void Caress()
    {
        catAnimator.SetTrigger("CatCaress");
        Invoke("Lie", minorDelay);
    }

    void Lie()
    {
        catAnimator.SetTrigger("CatLie");
        Invoke("Sleep", minorDelay);
    }

    void Sleep()
    {
        catAnimator.SetTrigger("CatSleep");
        Invoke("Sit", minorDelay);
    }

    void Sit()
    {
        catAnimator.SetTrigger("CatSit");
        Invoke("Start", minorDelay);
    }

}
