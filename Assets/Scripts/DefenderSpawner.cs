using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject defender;

    private void OnMouseDown() {
        SpawnDefender();
    }

    private void SpawnDefender() {
        Vector2 mouseLoc = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mouseLoc);
        GameObject gameDefender = Instantiate(defender, worldPos, Quaternion.identity);
    }
}