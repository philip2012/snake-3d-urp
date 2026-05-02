using UnityEngine;
using System.Collections.Generic;

public class SnakeBodyFollower: MonoBehaviour
{
    [SerializeField] private SnakeGrowth snakeGrowth;
    [SerializeField] private float segmentSpacing = 0.5f;
    [SerializeField] private float followSmoothness = 22f;

    private List<Vector3> positionHistory = new List<Vector3>();

    void Update()
    {
        positionHistory.Insert(0, transform.position);
        for (int i = 0; i < snakeGrowth.Segments.Count; i++)
        {
            int historyIndex = Mathf.RoundToInt((i + 1) * segmentSpacing * 10f);
            if (historyIndex < positionHistory.Count)
            {
                Transform segment = snakeGrowth.Segments[i];

                segment.position = Vector3.Lerp(
                    segment.position,
                    positionHistory[historyIndex],
                    followSmoothness * Time.deltaTime
                );

                Vector3 direction = positionHistory[historyIndex] - segment.position;
                direction.y = 0f;

                if (direction != Vector3.zero)
                {
                    Quaternion targetRotation = Quaternion.LookRotation(direction);

                    segment.rotation = Quaternion.Lerp(
                        segment.rotation,
                        targetRotation,
                        followSmoothness * Time.deltaTime
                    );
                }
            }
        }
    }
}