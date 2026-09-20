using UnityEngine;

public class Collisions : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("You picked up a package");
        }

        if (collision.CompareTag("Customer"))
        {
            Debug.Log("You delivered a package");
        }

    }
}
