using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public float minTime = 12f;
    public float maxTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoRoutine(0));
    }

    // Update is called once per frame
    IEnumerator SpawnCoRoutine(float waitTime){
        yield return new WaitForSeconds(waitTime);
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(Random.Range(transform.position.x - 7, transform.position.x + 7), -1.4f,Random.Range(transform.position.z + 25, transform.position.z + 70)), Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime, maxTime)));
    }
}
