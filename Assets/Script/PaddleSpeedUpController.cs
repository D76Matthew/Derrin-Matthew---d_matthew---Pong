using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUpController : MonoBehaviour
{
    public Collider2D ball;
    public Collider2D paddleleft;
    public Collider2D paddleright;
    public float magnitude;
    public PowerUpManager manager;
    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleleft.GetComponent<PaddleController>().ActivatePaddleSpeedUp(magnitude);
            paddleright.GetComponent<PaddleController>().ActivatePaddleSpeedUp(magnitude);
            manager.RemovePU(gameObject);

        }
    }

}
