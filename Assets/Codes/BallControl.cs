using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    Rigidbody physics;
    public int speed;
    int counter = 0;
    public int numberOfObjectsToCollect;
    public Text counterText;
    public Text gameOverText;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontal, 0, vertical);
        physics.AddForce(vec*speed);
        //Debug.Log("yatay =" + horizontal + " dikey = " + vertical);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Cube")
        {
            other.gameObject.SetActive(false);
            counter++;
            counterText.text = "Counter = " + counter;

            if (counter==numberOfObjectsToCollect)
            {
                gameOverText.text = "GAME OVER";
            }

        }
    }
}
