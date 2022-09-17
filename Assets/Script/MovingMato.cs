//https://goodlucknetlife.com/unity-object-auto-move/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingMato : MonoBehaviour
{
    private Vector3 targetpos;
    void Start(){
        targetpos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetpos.x, targetpos.y, Mathf.Sin(Time.time) * 5.0f + targetpos.z);
    }
}
