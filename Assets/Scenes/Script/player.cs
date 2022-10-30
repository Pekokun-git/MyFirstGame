using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4)
                this.transform.position += vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RighArrow))
        {
            if (this.transform.position.x < 4)
                thiss.transform.position += Vector3.rihjt * speed * Time.deltaTime;
        }
    }
}
