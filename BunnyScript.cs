using UnityEngine;
using UnityEngine.InputSystem;

public class BunnyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool bunnyIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && bunnyIsAlive == true) // Ask the computer if the space bar has been pressed
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; // Means that the bunny is going (0,1) position up
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        bunnyIsAlive = false;
    }
}
