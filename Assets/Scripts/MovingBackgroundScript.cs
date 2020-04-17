using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Renderer bgRend;
    private float speed = 0f;

    void Start()
    {

    }
    public void GetTheForce(Vector2 kick)
    {
        speed = kick.x;
    }
    // Update is called once per frame
    void Update()
    {
        if (speed > 0)
        {
            speed -= 0.001f;
        }
        bgRend.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
}
