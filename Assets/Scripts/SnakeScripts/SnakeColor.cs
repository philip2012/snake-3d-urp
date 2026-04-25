using UnityEngine;

public class SnakeColor: MonoBehaviour
{
    public Color32 cyan = new Color32(0, 255, 255, 1);
    void Start()
    {
        GetComponent<Renderer>().material.color = cyan;
    }
}