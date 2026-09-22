using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float regularSpeed = 5f;

    [SerializeField] TMP_Text boostText;

    void Start()
    {
        boostText.gameObject.SetActive(false);
        GetComponent<TrailRenderer>().enabled = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            currentSpeed = boostSpeed;
            boostText.gameObject.SetActive(true);
            GetComponent<TrailRenderer>().enabled = true;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("WorldCollision"))
        {
            currentSpeed = regularSpeed;
            boostText.gameObject.SetActive(false);
            GetComponent<TrailRenderer>().enabled = false;
        }
    }

    void Update()
    {
        float move = 0f;
        float steer = 0f;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            move = 1f;
        }

        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }

        else if (Keyboard.current.downArrowKey.isPressed)
        {
            move = -1f;
        }

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

}
