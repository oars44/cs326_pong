using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_control : MonoBehaviour
{
    public bool right = true;
    public float speed = 1;
    float dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            dir = Input.GetAxisRaw("Vertical");
        }
        else
        {
            dir = Input.GetAxisRaw("p2");
        }

        if (dir > 0 && transform.position.y < 5.5f)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + (dir * speed), transform.position.z);
        }

        if (dir < 0 && transform.position.y > -3.5f)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + (dir * speed), transform.position.z);
        }
    }
}
