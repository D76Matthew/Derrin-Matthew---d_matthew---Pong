using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    // Start is called before the first frame update
    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    public void ResetBall()
    {
        transform.position = resetPosition;
    }
}
