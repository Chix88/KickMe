using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kikcing : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float forcekick = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var rotation = transform.parent.eulerAngles.z * Mathf.Deg2Rad;
            Vector2 kick  = new Vector2(Mathf.Cos(rotation), Mathf.Sin(rotation));

           
            gameObject.GetComponent<Rigidbody2D>().AddForce(kick * 500);
            transform.parent = null;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            
        }

    }
}
