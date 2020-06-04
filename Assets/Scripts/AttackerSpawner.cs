using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    [SerializeField]
    private float minSpawnDelay = 1f;

    [SerializeField]
    private float maxSpawnDelay = 5f;

    [SerializeField]
    private Attacker attacker;
    
    private bool _spawn = true;    
    
    // Start is called before the first frame update
    IEnumerator Start() {
        while (_spawn) {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            Spawn();
        }
    }

    private void Spawn() {
        Instantiate(attacker, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update() { }

}