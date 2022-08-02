using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public bool stopped;
    public GameObject Panel;


    // Start is called before the first frame update
    void Start()
    {
        stopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            stopped = !stopped;

        }
        if (stopped)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (!stopped)
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
