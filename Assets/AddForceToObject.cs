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
        if (Input.GetMouseButtonDown(0) && gameObject.transform.parent != null)
        {
            var shotAngle = transform.parent.eulerAngles.z * Mathf.Deg2Rad;
            Vector2 kick = new Vector2(Mathf.Cos(shotAngle), Mathf.Sin(shotAngle));
            sc.GetComponent<script>().GetTheForce(kick);

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, kick.y) * 500);
            Destroy(transform.parent.GetComponent<SpriteRenderer>(), 0.2f);
            transform.parent = null;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

        }
        else if (Input.GetMouseButtonDown(0) && gameObject.transform.parent == null)
        {
            var shotAngle = ar.transform.eulerAngles.z * Mathf.Deg2Rad;
            Vector2 kick = new Vector2(Mathf.Cos(shotAngle), Mathf.Sin(shotAngle));
            sc.GetComponent<script>().GetTheForce(kick);

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, kick.y) * 500);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

        }
    }
}
