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
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnVegetable());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnVegetable()
    {
        yield return new WaitForSeconds(spawnRate);
        spawnRate = Random.Range(1, 2);

        Instantiate(spwnblVeges[Random.Range(0, spwnblVeges.Count - 1)], spawnPositions[Random.Range(0, spawnPositions.Count-1)],this.transform.rotation);
        
        
    }

    
}
