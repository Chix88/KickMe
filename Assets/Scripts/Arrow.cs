using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private float _angle = 90;
    private float _speed = 1;

    private bool up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = (Mathf.Sin(Time.time * _speed ) + 1) / 2 * _angle;  //sin go from -1 to 1 , so when we add +1 it goes from 0 to 2 , so when we divide by 2 it go from 0 to 1, the 90 is the degree , 
        transform.eulerAngles = new Vector3(0,0,angle);
    }

   
    
}
