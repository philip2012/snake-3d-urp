using UnityEngine;
using System.Collections.Generic;

public class SnakeGrowth : MonoBehaviour
{
    [SerializeField] private GameObject segmentPrefab;
    private List<Transform> segments = new List<Transform>();

    public void Grow()
    {
        Vector3 spawnPosition;

        if (segments.Count == 0)
        {
            spawnPosition = transform.position;
        } 
        else
        {
            spawnPosition = segments[segments.Count - 1].position;
        }

        GameObject newSegment = Instantiate(segmentPrefab, spawnPosition, Quaternion.identity);
        segments.Add(newSegment.transform);
    }
}
