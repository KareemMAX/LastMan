using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public float rotateSpeed = 1f;
    public Transform rotateAround;
    public float rotateAroundSpeed = 1f;
    public Vector3 axis = Vector3.up;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.Self);
        if(rotateAround != null){
            transform.RotateAround(rotateAround.position, axis, rotateAroundSpeed * Time.deltaTime);
        }
    }
}
