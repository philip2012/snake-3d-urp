using UnityEngine;

public class SnakeCollision: MonoBehaviour
{
    [SerializeField] private FoodSpawner foodSpawner;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food") == true)
        {
            Destroy(other.gameObject);
            foodSpawner.RespawnFood();
        }
    }
}