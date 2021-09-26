using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    public GameObject ground;
    public Transform groundTransform;
    public float offset = 1900f;

    Vector3 groundPosition;
    float zGroundPosition;


    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            //Delete and move ground for continuous run
            groundPosition = groundTransform.position;

            zGroundPosition = groundPosition.z + offset;
            groundPosition[2] = zGroundPosition;
            //groundPosition[1] = groundPosition.y - .001f;


            Destroy(ground);

            Instantiate(ground, groundPosition, Quaternion.identity);
        }
     }

}
