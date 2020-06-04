using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    
    [SerializeField]
    private int currentHealth = 100;

    [SerializeField]
    private GameObject deathVfx;
    public int CurrentHealth {
        get => currentHealth;
        set => currentHealth = value;
    }

    private void Update() {
        if (currentHealth <= 0) {
            if (deathVfx) {
                GameObject death = Instantiate(deathVfx, transform.position, Quaternion.identity);
                Destroy(death, 1f);
            }
            Destroy(gameObject);
        }
    }
}