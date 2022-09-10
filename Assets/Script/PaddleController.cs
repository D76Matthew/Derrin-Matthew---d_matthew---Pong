using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Vector2 movement;
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    public float PUTime;
    private float timer;
    private Vector3 orgsize;
    private float orgspeed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        timer = 0;
        orgsize = transform.localScale;
        orgspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // take input
        Vector2 movement = GetInput();
        // object movement from input
        MoveObject(movement);
        //Debug.Log("speed = " + speed);

        timer -= Time.deltaTime;
        if (timer <=0)
        {
            transform.localScale = orgsize;
            speed = orgspeed;
        }
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
        rig.velocity = movement*speed;
    }
    public void ActivatePaddleSpeedUp(float magnitude)
    {
        speed *= magnitude;
        timer = PUTime;
    }
    public void ActivatePaddleBigger(float magnitude)
    {
        var newscale = transform.localScale;
        newscale.y *= magnitude;
        transform.localScale = newscale;
        timer = PUTime;
    }

}
