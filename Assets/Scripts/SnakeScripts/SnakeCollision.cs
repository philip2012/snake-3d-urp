using UnityEngine;

public class SnakeCollision: MonoBehaviour
{
    [SerializeField] private FoodSpawner foodSpawner;
    [SerializeField] private SnakeGrowth snakeGrowth;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food") == true)
        {
            foodSpawner.RespawnFood();
            snakeGrowth.Grow();
        }
    }
}