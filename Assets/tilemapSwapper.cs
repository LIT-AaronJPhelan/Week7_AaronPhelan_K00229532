using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemapSwapper : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager.instance.tilemapA.SetActive(!LevelManager.instance.tilemapA.activeSelf);
        LevelManager.instance.tilemapB.SetActive(!LevelManager.instance.tilemapB.activeSelf);

        LevelManager.instance.startTimer = true;
    }
}
