using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{

    public GameObject spawnObj;
    public float spawnMin = -6f;
    public float spawnMax = 6f;
    GameObject player;
    public Vector3 spawnPoint;
    public float offset;
    public Quaternion rotation;
    public float x_offset = 3f;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("player");
        Spawn();
    }

    void Spawn()
    {
        spawnPoint.z = player.transform.position.z + offset;
        spawnPoint.x += x_offset;
        x_offset = -x_offset;
        Instantiate(spawnObj, spawnPoint, rotation);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
