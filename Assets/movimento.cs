using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 m;
    void Start()
    {
        m = new Vector3(02, 02, 03);
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            m.y = 0.05f;
            transform.Translate(m);
        }
        m.Set(0, 0, 0);
    }
}
