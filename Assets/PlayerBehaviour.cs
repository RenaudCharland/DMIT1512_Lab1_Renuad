using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }
    }
}
