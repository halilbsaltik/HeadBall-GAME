using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gool : MonoBehaviour
{
    public int firstGoal, secondGoal;
    public Text Score1,Score2;
    Rigidbody2D rigidbodyGoal;
    public bool haveGoal;
    public Vector3 Gamer1, Gamer2, Ball;
    // Start is called before the first frame update
    void Start()
    {
        Gamer1 = GameObject.FindWithTag("Player1").transform.position;
        Gamer2 = GameObject.FindWithTag("Player2").transform.position;
        Ball = transform.position;
        haveGoal = false;

    }

    // Update is called once per frame
    void Update()
    {
        Score1.text = "" + firstGoal;
        Score2.text = "" + secondGoal;
    }

    void OnCollisionEnter2D(Collision2D getInTouch)
    {
        if (getInTouch.gameObject.name=="Goal1")
        {
            if(haveGoal == false)
            {

            }
            firstGoal++;
            haveGoal = true;
            Invoke("RestartIng", 0);

        }
        if (getInTouch.gameObject.name == "Goal2")
        {
            if (haveGoal == false)
            {

            }

            secondGoal++;
            haveGoal = true;
            Invoke("RestartIng", 0);

        }
        
    }
    void RestartIng()
    {
        GameObject.FindWithTag("Player1").transform.position = Gamer1;
        GameObject.FindWithTag("Player2").transform.position = Gamer2;
        transform.position = Ball;
        haveGoal = false;
        CancelInvoke("RestartIng");

    }
}
