using UnityEngine;

public class Collisions : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("You picked up a package");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("You delivered a package");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject);
        }

    }
}
