using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTest : MonoBehaviour
{

    public GameObject point1;
    public GameObject point2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero, point1.transform.position, Color.yellow, Time.deltaTime);
        Debug.DrawLine(Vector3.zero, point2.transform.position, Color.green, Time.deltaTime);

        //print(Angle(point1.transform.position, point2.transform.position));
        
    }

    float Angle(Vector3 v1, Vector3 v2)
    {
        float denominator = Mathf.Sqrt(v1.sqrMagnitude * v2.sqrMagnitude);
        float dot = (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z) / denominator;

        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
        //print(angle);
        return angle;
    }
}
