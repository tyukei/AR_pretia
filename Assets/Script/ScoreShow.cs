using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShow : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Text;

    // Start is called before the first frame update
    void Start()
    {
        Text.text = "HitRed: "+Data.Instance.score+"times";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
