using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed;
    public float maxSpeed = 20;
    public float accelerationRate = 5;
    public float decelerationRate = 10;

    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        ///adsiuaisudh
        ///asdhiuasiud
        ///acfjabcahsiduytwuetoqetyoqw 
        ///
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Move(horizontal, vertical);
    }

    void Move(float hor, float ver)
    {
        if (hor != 0 || ver != 0)
        {
            //accelerate
            movement.Set(hor, 0, ver);
            speed = Mathf.Min(speed + accelerationRate * Time.deltaTime, maxSpeed);
        }
        else
        {
            
            speed = Mathf.Max(speed - decelerationRate * Time.deltaTime, 0);
        }

        movement = movement.normalized * speed * Time.deltaTime;

        GetComponent<Rigidbody>().position = movement;
    }
}
