using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Vector2 movement;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // take input
        Vector2 movement = GetInput();
        // object movement from input
        MoveObject(movement);
    }
    private Vector2 GetInput()
    {
        // take input
       
        if (Input.GetKey(upKey))
        {
            //Up
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            //Down
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        // object movement from input
        rig.velocity = movement;
    }
}
