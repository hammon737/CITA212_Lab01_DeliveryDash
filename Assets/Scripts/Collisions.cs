using UnityEngine;

public class Collisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crash!!!");
    }
}
