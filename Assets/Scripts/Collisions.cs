using UnityEngine;

public class Collisions : MonoBehaviour
{
    bool hasPackage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("You picked up a package");
            hasPackage = true;
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("You delivered a package");
            hasPackage = false;
        }

    }
}
