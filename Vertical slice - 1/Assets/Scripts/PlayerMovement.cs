using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;

    private float speed = 10f;
    private float tiltSpeed = 30f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, tiltSpeed / 2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))    
        {
            transform.Rotate(0f, 0f, -tiltSpeed /2 * Time.deltaTime);
        }

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
        transform.Rotate(0f, Input.GetAxis("Horizontal") * (tiltSpeed * 2.5f) * Time.deltaTime, -Input.GetAxis("Horizontal") * tiltSpeed * Time.deltaTime);

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
