using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

    private Transform trans;
    [SerializeField] private float speed;

    private void Awake()
    {
        trans = GetComponent<Transform>();
    }
	
	void Update () {

        trans.position += transform.forward * Time.deltaTime * speed;
	}
}
