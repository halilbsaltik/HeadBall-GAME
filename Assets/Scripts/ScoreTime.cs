using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTime : MonoBehaviour
{
    public float gameTime, givegameTime;
    public Text scoreTime;
    
    // Start is called before the first frame update
    void Start()
    {
        gameTime = givegameTime;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTime.text = gameTime.ToString("f2");
        gameTime -= Time.deltaTime;
        if (gameTime <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
