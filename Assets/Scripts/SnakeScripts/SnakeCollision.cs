using UnityEngine;

public class SnakeCollision: MonoBehaviour
{
    [SerializeField] private FoodSpawner foodSpawner;
    [SerializeField] private SnakeGrowth snakeGrowth;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private SnakeController snakeController;
    [SerializeField] private GameManager gameManager;

    private bool isConsumingFood;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            gameManager.GameOver();
        }
        
        if (isConsumingFood)
        {
            return;
        }
        if (!other.CompareTag("Food"))
        {
            return;
        }

        isConsumingFood = true;

        foodSpawner.RespawnFood();
        snakeGrowth.Grow();
        scoreManager.AddFoodScore();
        snakeController.IncreaseSpeed();

        Invoke(nameof(ResetConsumeLock), 0.1f);
    }

    private void ResetConsumeLock()
    {
        isConsumingFood = false;
    }
}