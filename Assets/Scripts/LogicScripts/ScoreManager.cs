using UnityEngine;

public class ScoreManager: MonoBehaviour
{
    private int score;
    private int combo;
    private float comboTimer;

    // tunables
    [SerializeField] private int baseFoodScore = 10;
    [SerializeField] private float comboResetTime = 4f;

    // getters for any script's interest in these values
    public int Score => score;
    public int Combo => combo;

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