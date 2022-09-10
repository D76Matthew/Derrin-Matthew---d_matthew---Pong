using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    // Start is called before the first frame update
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    private Vector2 orgspeed;
    public float PUTime;
    private float timer;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
        orgspeed = speed;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            speed = orgspeed;
        }
    }

    // Update is called once per frame
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
        timer = PUTime;
    }
}
