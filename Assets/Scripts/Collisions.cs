using UnityEngine;
using TMPro;

public class Collisions : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;
    [SerializeField] TMP_Text score;

    int deliveries = 0;

    void Start()
    {
        UpdateScoreDisplay();
    }

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
            deliveries += 1;
            UpdateScoreDisplay();
            Destroy(collision.gameObject);
        }

    }

    void UpdateScoreDisplay()
    {
        score.text = $"Packages Delivered: {deliveries}";
    }
}
