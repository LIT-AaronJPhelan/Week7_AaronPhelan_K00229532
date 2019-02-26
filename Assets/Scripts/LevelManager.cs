using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject tilemapA;
    public GameObject tilemapB;

    public Text timerText;
    public float timer;

    public bool startTimer;

    public bool timerOver;


    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
    }

    private void Update()
    {
        if(startTimer && !timerOver)
        {
            timer += Time.deltaTime;
        }


        timerText.text = "Time:" + Mathf.Ceil(timer);
    }

    
}
