using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    public void Show()
    {
        gameOverPanel.SetActive(true);
    }
}