using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mato : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] private TextMeshProUGUI Text;

    void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得
        if(collision.gameObject.name == "Bullet(Clone)"){
            Debug.Log("hit");
            Data.Instance.score++;
            Instantiate (explosionPrefab, transform.position, Quaternion.identity);
            Text.text = "Hit: "+Data.Instance.score+"times";
        }else{
            Debug.Log("Hit other");
        }
    }
}

