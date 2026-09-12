using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.03f;
    
    void Update()
    {
        if (Keyboard.current.wKey.isPressed) 
        {
            Debug.Log("we are pushing forward");
        }

        else if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("we are pushing left");
        }

        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("we are pushing right");
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("we are pushing back");
        }

        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0,moveSpeed,0);
    }
}
