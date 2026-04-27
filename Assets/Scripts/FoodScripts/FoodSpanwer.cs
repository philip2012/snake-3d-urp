using UnityEngine;

public class FoodSpawner: MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private GameObject ground;
    [SerializeField] private float spawnPadding = 1f;
    [SerializeField] private float spawnHeightOffset = 0.5f;

    private Bounds groundBounds;
    private Renderer groundRenderer;
    private GameObject currentFood;

    void Start()
    {
        groundRenderer = ground.GetComponent<Renderer>();
        groundBounds = groundRenderer.bounds;
        SpawnFood();
    }

    public void RespawnFood()
    {
        SpawnFood();
    }

    private void SpawnFood()
    {
        if (currentFood != null)
        {
            Destroy(currentFood);
            currentFood = null;
        }
        float paddedRandomX = Random.Range(groundBounds.min.x + spawnPadding, groundBounds.max.x - spawnPadding);
        float paddedYPos = groundBounds.max.y + spawnHeightOffset;
        float paddedRandomZ = Random.Range(groundBounds.min.z + spawnPadding, groundBounds.max.z - spawnPadding);
        Vector3 newPos = new Vector3(paddedRandomX, paddedYPos, paddedRandomZ);

        currentFood = Instantiate(applePrefab, newPos, Quaternion.identity);
    }
}