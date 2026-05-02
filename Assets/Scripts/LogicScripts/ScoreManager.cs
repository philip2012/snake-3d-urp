using UnityEngine;

public class ScoreManager: MonoBehaviour
{
    private int score;
    private int combo;
    private float comboTimer;

    // tunables
    [SerializeField] private int baseFoodScore = 10;
    [SerializeField] private float comboResetTime = 3f;

    void Update()
    {
        if (comboTimer > 0)
        {
            comboTimer -= Time.deltaTime;

            if (comboTimer <= 0)
            {
                comboTimer = 0;
                combo = 0;
            }
        }
    }

    public void AddFoodScore()
    {
        combo += 1;
        int points = baseFoodScore * combo;
        score += points;
        comboTimer = comboResetTime;

        Debug.Log($"Score: {score} | Combo: {combo} | Gained: {points}");
    }
}