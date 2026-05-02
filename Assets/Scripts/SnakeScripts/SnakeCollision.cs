using UnityEngine;

public class SnakeCollision: MonoBehaviour
{
    [SerializeField] private FoodSpawner foodSpawner;
    [SerializeField] private SnakeGrowth snakeGrowth;
    [SerializeField] private ScoreManager scoreManager;

    private bool isConsumingFood;

    void OnTriggerEnter(Collider other)
    {
        if (isConsumingFood == true)
        {
            return;
        }
        if (other.CompareTag("Food") == false)
        {
            return;
        }

        isConsumingFood = true;

        foodSpawner.RespawnFood();
        snakeGrowth.Grow();
        scoreManager.AddFoodScore();

        Invoke(nameof(ResetConsumeLock), 0.1f);
    }

    private void ResetConsumeLock()
    {
        isConsumingFood = false;
    }
}