using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField]
    private int health = 100;

    public int Health1 {
        get => health;
        set => health = value;
    }
}