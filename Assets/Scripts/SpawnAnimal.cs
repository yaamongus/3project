using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject[] animals;
    private int index;

    private int indexSpawn;

    public Transform[] spawns;
    private Vector3 position;
    private int spawnStart = 5;
    private int spawnReapeat = 4;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnStart, spawnReapeat);
    }
    void Spawn()
    {
        position = new Vector3(Random.Range(0, 0),  0,  Random.Range(0,0));
        index = Random.Range(0, animals.Length);
        indexSpawn = Random.Range(0, spawns.Length);
        Instantiate(animals[index], spawns[indexSpawn].position,  spawns[indexSpawn].rotation);
    }
}
