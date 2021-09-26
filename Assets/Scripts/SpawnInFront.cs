using UnityEngine;
using System.Linq;

public class SpawnInFront : MonoBehaviour
{
    public Transform player;
    public float offset;
    public Transform[] spawnPoints;
    public GameObject[] humanObstacles;

	public float timeBetweenWaves = 1f;

	private float timeToSpawn = 2f;
    Vector3 spawnPosition;
    float zPosition;

    void FixedUpdate()
    {
        zPosition = 0f;
        spawnPosition = player.position + new Vector3 (0,0,offset);
        zPosition = spawnPosition.z;
        transform.position  = new Vector3 (1,2,zPosition);

        GameObject og = GameObject.Find("Text");
        float scoreRef = og.GetComponent<Score>().scoreRef;
        

        if (Time.time >= timeToSpawn)
		{
            if (scoreRef < 999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweenWaves;
            }
            if (scoreRef > 1000f && scoreRef < 1999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .1f);
            }
            if (scoreRef > 2000f && scoreRef < 2999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .2f);
            }
            if (scoreRef > 3000f && scoreRef < 3999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .3f);
            }
            if (scoreRef > 4000f && scoreRef < 4999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .4f);
            }
            if (scoreRef > 5000f && scoreRef < 5999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .5f);
            }
            if (scoreRef > 6000f && scoreRef < 6999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .6f);
            }
            if (scoreRef > 7000f && scoreRef < 7999f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + (timeBetweenWaves - .7f);
            }
		}
    }

    void SpawnBlocks()
	{
        int randomLength = Random.Range(1, spawnPoints.Length);
        int arraySpawn = randomLength;
        int[] arrayRange = new int[arraySpawn];

        for (int i = 0; i < arraySpawn; i++)
        {
            arrayRange[i] = Random.Range(0, spawnPoints.Length);
        }

        int[] arrayDistinct = arrayRange.Distinct().ToArray();
    
		for (int i = 0; i < spawnPoints.Length; i++)
		{
            foreach(int n in arrayDistinct)
            {
                if (n == i)
                {
                    int randomHumanIndex = Random.Range(0,humanObstacles.Length);

                    for (int h = 0; h < humanObstacles.Length; h++)
                    {
                        if (randomHumanIndex == h)
                        {
                            Vector3 instantiatePlace = spawnPoints[i].position;
                            Instantiate(humanObstacles[h], instantiatePlace + new Vector3 (0,0,offset), Quaternion.identity);
                        }
                    }
                }
            }
		}
	}
}
