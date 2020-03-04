using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 30f; // Movement Speed from the Player
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveUp();
        MoveDown();
        MoveRight();
        MoveLeft();
    }

    private void MoveUp()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.position += Vector2.up * Time.deltaTime * speed;
        }
    }

    private void MoveDown()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.position += Vector2.down * Time.deltaTime * speed;
        }
    }

    private void MoveRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.position += Vector2.right * Time.deltaTime * speed;
        }
    }
    private void MoveLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.position += Vector2.left * Time.deltaTime * speed;
        }
    }
}
