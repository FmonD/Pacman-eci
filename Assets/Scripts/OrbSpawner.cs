using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orbPrefab;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;

    private GameObject currentOrb;

    void Start()
    {
        SpawnOrb();
    }

    void Update()
    {
        if (currentOrb == null)
            SpawnOrb();
    }

    void SpawnOrb()
    {
        Vector3 randomPos = new Vector3(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            0f,
            Random.Range(spawnAreaMin.z, spawnAreaMax.z)
        );

        currentOrb = Instantiate(orbPrefab, randomPos, Quaternion.identity);
    }
}
