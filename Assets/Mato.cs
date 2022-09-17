using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mato : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] private TextMeshProUGUI Text;

    void OnCollisionEnter(Collision collision){
        Data.Instance.score++;
        Instantiate (explosionPrefab, transform.position, Quaternion.identity);
        Text.text = "Hit: "+Data.Instance.score+"times";
    }

}
