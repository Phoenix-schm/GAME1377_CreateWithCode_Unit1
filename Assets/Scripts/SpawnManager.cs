using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnVehicleList;

    [SerializeField]
    private Transform[] spawnLocations;

    private float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomVehicle();
    }


    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer > 1.0f)
        {
            spawnTimer = 0;
            SpawnRandomVehicle();
        }
    }

    /// <summary>
    /// Spawns a random vehicle at a random premade location
    /// </summary>
    private void SpawnRandomVehicle()
    {
        int spawnLocationIndex = Random.Range(0, spawnLocations.Length);
        int vehicleListIndex = Random.Range(0, spawnVehicleList.Length);

        GameObject currentVehicle = spawnVehicleList[vehicleListIndex];
        Transform currentSpawnTransform = spawnLocations[spawnLocationIndex];

        Instantiate(currentVehicle, currentSpawnTransform.position, currentSpawnTransform.rotation, currentSpawnTransform);
    }
}
