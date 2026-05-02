using UnityEngine;
using TMPro;

public class ScoreUI: MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text comboText;

    private void Update()
    {
        scoreText.text = $"SCORE: {scoreManager.Score}";
        comboText.text = $"COMBO: x{scoreManager.Combo}";
    }    
}