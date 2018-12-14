using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;

    private float speed = 10f;
    private float tiltSpeed = 100f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Neutral();
    }

    void Neutral()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
            //new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + speed * Time.deltaTime);
    }

    public void MoveVertical()
    {
        transform.Rotate(Input.GetAxis("Vertical") * tiltSpeed * Time.deltaTime, 0f, 0f);
    }

    public void MoveHorizontal()
    {
        transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal") * tiltSpeed * Time.deltaTime);
    }

    //public void MoveLeft()
    //{
    //    transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);
    //}

    //public void MoveRight()
    //{
    //    transform.Rotate(Vector3.up* rotSpeed * Time.deltaTime);
    //}

    //public void MoveUp()
    //{
    //    transform.Rotate(Vector3.left * rotSpeed * Time.deltaTime);
    //}

    //public void MoveDown()
    //{
    //    transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
    //}

}
