using UnityEngine;

public class FoodSpawner: MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private GameObject ground;
    [SerializeField] private float spawnPadding = 1f;

    private Bounds groundBounds;
    private Renderer groundRenderer;
    private GameObject currentFood;

    void Start()
    {
        groundRenderer = ground.GetComponent<Renderer>();
        groundBounds = groundRenderer.bounds;
        SpawnFood();
    }

    private void SpawnFood()
    {
        if (currentFood != null)
        {
            Destroy(currentFood);
        }
        float paddedRandomX = Random.Range(groundBounds.min.x + spawnPadding, groundBounds.max.x - spawnPadding);
        float yPos = groundBounds.max.y;
        float paddedRandomZ = Random.Range(groundBounds.min.z + spawnPadding, groundBounds.max.z - spawnPadding);
        Vector3 newPos = new Vector3(paddedRandomX, yPos, paddedRandomZ);

        currentFood = Instantiate(applePrefab, newPos, Quaternion.identity);
    }
}