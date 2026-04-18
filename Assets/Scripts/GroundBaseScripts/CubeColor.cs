using UnityEngine;

public class CubeColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = UnityEngine.Color.green;
    }
}
