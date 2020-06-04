using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {
    [SerializeField]
    private int damage = 100;

    private void OnTriggerEnter2D(Collider2D other) {
        Health healthComponent = other.GetComponent<Health>();
        if (healthComponent != null) {
            healthComponent.CurrentHealth -= damage;
            Destroy(gameObject);
        }
    }
}