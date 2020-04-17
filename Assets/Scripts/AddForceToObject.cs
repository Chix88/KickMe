using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToObject : MonoBehaviour
{
    [SerializeField] private float forcekick = 0;
    private AddForceToObject af;
    public GameObject sc;
    public Arrow ar;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.transform.parent != null) // when clicked on the mouse , and the player is still attached to the launcher
        {
            var shotAngle = transform.parent.eulerAngles.z * Mathf.Deg2Rad;     // add force in the angle of the launcher
            Vector2 kick = new Vector2(Mathf.Cos(shotAngle), Mathf.Sin(shotAngle));
            sc.GetComponent<MovingBackgroundScript>().GetTheForce(kick);                        // Send the vector to the script that handel the BG movement;

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, kick.y) * 500);  //need to change the 500 with a variable that controle the amount of 
            Destroy(transform.parent.GetComponent<SpriteRenderer>(), 0.2f);
            transform.parent = null;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

        }
        else if (Input.GetMouseButtonDown(0) && gameObject.transform.parent == null) // when clicked on the mouse and the player left the launcher
        {
            float shotAngle = Mathf.PI/4f; // add force with the angle 45°
            Vector2 kick = new Vector2(Mathf.Cos(shotAngle), Mathf.Sin(shotAngle));
            sc.GetComponent<MovingBackgroundScript>().GetTheForce(kick);

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, kick.y) * 500);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

        }
    }
}
