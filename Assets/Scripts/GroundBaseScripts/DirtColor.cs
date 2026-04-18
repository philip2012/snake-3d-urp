using UnityEngine;

public class DirtColor: MonoBehaviour
{
    public Color32 dirtBrown = new Color32(128, 57, 19, 1);
    void Start()
    {
        GetComponent<Renderer>().material.color = dirtBrown;
    }
}