using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelContExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnContinue()
    {
        Application.LoadLevel("Scene1");
    }
    public void BtnExit()
    {
        Application.Quit();
    }
}
