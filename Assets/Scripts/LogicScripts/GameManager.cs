using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

    private void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    private void Update()
    {
        if (!isGameOver)
        {
            return;
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            RestartGame();
        }
    }
}