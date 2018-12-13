using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject lookTarget;
    public GameObject posTarget;

    private Vector3 targetPos = new Vector3();
    private Vector3 targetRot = new Vector3();
    
    [Header("Position Offset")]
    [SerializeField]
    private float xPos;
    [SerializeField]
    private float yPos;
    [SerializeField]
    private float zPos;

    [Header("Rotation")]
    [SerializeField]
    private float xRot;
    [SerializeField]
    private float yRot;
    [SerializeField]
    private float zRot;

    //[Header("Follow Distance")]
    //[SerializeField]
    //private float dist;

    [Header("Settings")]
    [SerializeField]
    private float rotSmoothing;
    [SerializeField]
    private float posSmoothing;



    void FixedUpdate () {

        posTarget.transform.localPosition = new Vector3(0f + xPos, 0f + yPos, 0f + zPos);

        transform.position = Vector3.Lerp(posTarget.transform.position ,posTarget.transform.forward + posTarget.transform.position, posSmoothing);

        transform.LookAt(lookTarget.transform);

        transform.rotation = (lookTarget.transform.rotation);

        //transform.rotation = Quaternion.Lerp(transform.rotation, lookTarget.transform.rotation, rotSmoothing);

        //if (transform.rotation.y < 0)
        //{
        //    transform.rotation =  Quaternion.Euler(transform.rotation.x, -transform.rotation.y, transform.rotation.z);
        //}

    }
}




        //transform.position = Vector3.Lerp(transform.position, (targetPos + new Vector3(xPos, yPos, zPos)), posSmoothing);

//transform.forward = Vector3.Lerp(transform.rotation.eulerAngles, targetPos - this.transform.position, rotSmoothing);


        //targetRot = target.transform.rotation.eulerAngles;

//if(transform.rotation.eulerAngles != targetRot)
//{
//transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, new Vector3(targetRot.x + xRot, targetRot.y + yRot, targetRot.z + zRot), rotSmoothing));
//}



//targetPos = target.transform.position;

//pos = targetPos + new Vector3(xPos,yPos,zPos);

////transform.position = pos;


//targetRot = target.transform.rotation.eulerAngles;

//rot = Quaternion.Euler(Vector3.Lerp(targetRot, new Vector3(targetRot.x + xRot, targetRot.y + yRot, targetRot.z + zRot), rotationSmoothing));

//transform.SetPositionAndRotation(pos, rot);
