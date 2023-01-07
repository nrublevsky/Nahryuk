using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    List<GameObject> spwnblVeges;
    
    public List<Vector3> spawnPositions;

    public Transform randomPosition;
    public float delay = 1f;
    public float spawnRate;

    bool gameRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(2, 3);

        InvokeRepeating("SpawnVegetable", delay,spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnVegetable()
    {
            StartCoroutine(Spawn());      
    }

    public IEnumerator Spawn()
    {
        /*spawnRate = Random.Range(2,3);
        yield return new WaitForSecondsRealtime(spawnRate);*/
        if (gameRunning)
        {         
            Instantiate(spwnblVeges[Random.Range(0, spwnblVeges.Count - 1)], spawnPositions[Random.Range(0, spawnPositions.Count - 1)], this.transform.rotation);
        }
        yield return null;
        
        
    }

    public void AddToBox()
    {
        Debug.Log("Added to Box");
    }

    
}
