using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCs : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMost_Wait;
    public float spawnLeast_Wait;
    public int startWait;
    public bool stop;
    private int randEnemy;
    

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    
    void Update()
    {
        
            
            spawnWait = Random.Range(spawnLeast_Wait, spawnMost_Wait);
        
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnemy = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
