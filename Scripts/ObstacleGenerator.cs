using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] itemPrefab;
    public float minTime = 52f;
    public float maxTime = 5f;
    private float zOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoRoutine(0));
    }

    // Update is called once per frame
    IEnumerator SpawnCoRoutine(float waitTime){
        yield return new WaitForSeconds(waitTime);
        zOffset = Random.Range(-100, 100);
        Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)], transform.position + new Vector3(0,0,zOffset), Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime, maxTime)));
    }

}
