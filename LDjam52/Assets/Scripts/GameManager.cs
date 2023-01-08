using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    List<GameObject> spwnblVeges;
    [SerializeField]
    List<GameObject> spwnblKakas;

    public List<Vector3> spawnPositions;

    public Transform randomPosition;
    public float delay = 1f;
    public float spawnRate;

    public int vegetableSpawned;

    public GameObject blockerL;
    public GameObject blockerR;
    private BlockerBehavior blBehavior;
    public bool blocking;

    bool gameRunning = true;

    public int reqBoxes;
    public int actualBoxes;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(2, 3);
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn5Vegetables()
    {
        if (vegetableSpawned > 5)
        {
            StartCoroutine(Spawn(spwnblVeges,spwnblKakas, spawnPositions));
        }
        
    }

    public IEnumerator Spawn(List<GameObject> veges,List<GameObject> kakas, List<Vector3> spawnPositions)
    {
        
        
        if (gameRunning)
        {
            spawnRate = Random.Range(2, 4);
            int random = Random.Range(1, 5);

            Quaternion randRot = Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));

            if (random > 3)
            {
                Instantiate(spwnblVeges[Random.Range(0, veges.Count)], spawnPositions[Random.Range(0, spawnPositions.Count)], randRot);
                vegetableSpawned++;
            }
            else
            {
                Instantiate(spwnblKakas[Random.Range(0, kakas.Count)], spawnPositions[Random.Range(0, spawnPositions.Count)], randRot);
            }
        }
        yield return new WaitForSeconds(spawnRate);
        yield return null;
    }



    public IEnumerator SwitchBlocker(GameObject blocker)
    {    
            blBehavior = blocker.GetComponent<BlockerBehavior>();
            blBehavior.SetBlocking();
            blocking = blBehavior.blocking;
               
        yield return null;
    }

    public void ControlGame() {

        if (actualBoxes == reqBoxes)
        {
            gameRunning = false;
        }
    }
}
