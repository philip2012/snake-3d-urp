using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SnakeGrowth : MonoBehaviour
{
    [SerializeField] private GameObject segmentPrefab;
    private List<Transform> segments = new List<Transform>();
    public List<Transform> Segments => segments;

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

        GameObject newSegment = Instantiate(segmentPrefab, spawnPosition, transform.rotation);
        segments.Add(newSegment.transform);

        Collider segmentCollider = newSegment.GetComponent<Collider>();

        if (segmentCollider != null)
        {
            segmentCollider.enabled = false;
            StartCoroutine(EnableColliderAfterDelay(segmentCollider, 0.3f));
        }
    }

    private IEnumerator EnableColliderAfterDelay(Collider segmentCollider, float delay)
    {
        yield return new WaitForSeconds(delay);

        if (segmentCollider != null)
        {
            segmentCollider.enabled = true;
        }
    }
}
