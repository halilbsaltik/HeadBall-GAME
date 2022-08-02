using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExit : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameEnter()
    {
        Application.LoadLevel(1);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
