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
            Quaternion randRot = Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
            Instantiate(spwnblVeges[Random.Range(0, spwnblVeges.Count)], spawnPositions[Random.Range(0, spawnPositions.Count)], randRot);
        }
        yield return null;
        
        
    }

    public void AddToBox(string name)
    {
        Debug.Log("Added " + name + " to Box");
    }

    
}
