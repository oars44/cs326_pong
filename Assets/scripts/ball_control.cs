using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    public float start_speed = 10f;
    private float speed;
    float dir;

    // Start is called before the first frame update
    void Start()
    {
        float x = transform.position.x;
        float z = transform.position.y;

        launch(x, z, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > 13)
        {
            launch(0, 0, -1);
        }
        if (transform.position.x < -13)
        {
            launch(0, 0, 1);
        }
    }

    private void launch(float x, float y, float xdir)
    {

        transform.position = new Vector3(x, y, 0);
        speed = start_speed;

        float dirx = Random.Range(0, 2);

        if (xdir == 0)
        {
            if (dirx == 0)
            {
                dirx = -1;
            }
        }
        else
            dirx = xdir;

        float diry = Random.Range(0, 2);
        if (diry == 0)
        {
            diry = -1;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(speed * dirx, speed * diry, 0f);
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "paddles")
        {
            GetComponent<Rigidbody>().velocity *= 1.5f;
        }
    }
}
