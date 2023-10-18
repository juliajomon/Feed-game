
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int spwanX = 20;
    private int spwanZ = 30;
    private int startDelay = 2;
    private float delay = 1.5f;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpwanRamdomAnimal", startDelay, delay);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpwanRamdomAnimal()
    {
        int animalIndex = Random.Range( 0,animalPrefabs.Length);
        Vector3 spwan = new Vector3(Random.Range(-spwanX, spwanX), 0, spwanZ);
        Instantiate(animalPrefabs[animalIndex], spwan, animalPrefabs[animalIndex].transform.rotation);

    }
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

}
