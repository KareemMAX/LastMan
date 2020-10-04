using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
 
public class FreeLockCameraMinDistance : MonoBehaviour
{
    CinemachineFreeLook freeLookCam;
    CinemachineTransposer transposer;
    Transform target;
    Transform cachedTransform;
    float zDampingDefaultValue;
    public float minDistance;
 
    void Start()
    {
        freeLookCam = GetComponent<CinemachineFreeLook>();
        transposer = freeLookCam.GetRig(1).GetCinemachineComponent<CinemachineTransposer>();
        target = freeLookCam.LookAt;
        cachedTransform = transform;
        zDampingDefaultValue = transposer.m_ZDamping;  
    }
 
    void Update()
    {
        float distance = Vector3.Distance(cachedTransform.position, target.position);
        minDistance = transposer.m_FollowOffset.z * -0.99f;
        if (distance <= minDistance)
        {
            transposer.m_ZDamping = 0f;
        }
        else
        {
            transposer.m_ZDamping = zDampingDefaultValue;
        }
    }
}