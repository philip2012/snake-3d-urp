using UnityEngine;

public class GameManager: MonoBehaviour
{
    private bool isGameOver;
    [SerializeField] private SnakeController snakeController;

    public void GameOver()
    {
        if (isGameOver)
        {
            return;
        }
        
        isGameOver = true;
        snakeController.SetMovementEnabled(false);
        Debug.Log("Game Over");
    }
}