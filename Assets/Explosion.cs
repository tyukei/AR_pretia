using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;

void OnCollisionEnter(Collision collision){
        Instantiate (explosionPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject,1f);
    }
}
