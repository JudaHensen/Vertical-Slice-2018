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

    private float x;
    private float y;
    private float z;

    [Header("Rotation")]
    [SerializeField]
    private float xRot;
    [SerializeField]
    private float yRot;
    [SerializeField]
    private float zRot;

    private float xShake = 0;
    private float yShake = 0;

    
    //[Header("Follow Distance")]
    //[SerializeField]
    //private float dist;

    [Header("Settings")]
    [SerializeField]
    private float rotSmoothing;
    [SerializeField]
    private float posSmoothing;


    private void Start()
    {
        x = xPos;
        y = yPos;
        z = zPos;
        posTarget.transform.localPosition = new Vector3(0f + xPos + xShake, 0f + yPos + yShake, 0f + zPos);
    }


    void FixedUpdate () {


        transform.position = Vector3.Lerp(posTarget.transform.position, posTarget.transform.forward + posTarget.transform.position, posSmoothing);

        transform.LookAt(lookTarget.transform);

        transform.rotation = (lookTarget.transform.rotation);
        
    }

    public IEnumerator CamShake (float magnitude, float duration)
    {

        Debug.Log("yeee");

        float elapsedTime = 0f;

        Vector3 pos = posTarget.transform.localPosition;

        while (elapsedTime < duration)
        {
            xShake = Random.Range(-1f, 1f) * magnitude;
            yShake = Random.Range(-1f, 1f) * magnitude;

            transform.position += new Vector3(xShake, yShake, 0);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        xPos = x;
        yPos = y;
        zPos = z;

    }
}