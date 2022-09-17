using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitRed : MonoBehaviour {
    
    [SerializeField]
    private TextMeshProUGUI Text;
    static int count = 0;

  // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HitRed"); // ログを表示する
        Text.text = "HitRed: "+count+"times";
        count++;
    }
}