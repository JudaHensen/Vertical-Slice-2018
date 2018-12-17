using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCheckPoint : MonoBehaviour {

    private BoxCollider col;

    void Start()
    {
        col = gameObject.AddComponent<BoxCollider>();
    }

    void Update () {
        transform.rotation = Quaternion.Euler(0f, Camera.main.transform.eulerAngles.y, 0f);
	}
}
