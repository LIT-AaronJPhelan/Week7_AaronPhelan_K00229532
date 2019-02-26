using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager.instance.startTimer = false;
        LevelManager.instance.timerText.color = Color.red;

        LevelManager.instance.timerOver = true;

    }
}
