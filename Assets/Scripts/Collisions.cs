using UnityEngine;

public class Collisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crash!!!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What was that??");
    }
}
