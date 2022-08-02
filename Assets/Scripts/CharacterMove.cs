using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public int Speed;
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0);
        if (Input.GetKey (KeyCode.D) && playerName =="1")
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) && playerName == "1")
        {
            transform.Translate(Speed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && playerName == "1")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300000);
        }
        if (Input.GetKey(KeyCode.RightArrow) && playerName == "2")
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && playerName == "2")
        {
            transform.Translate(Speed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && playerName == "2")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300000);
        }

    }
}
