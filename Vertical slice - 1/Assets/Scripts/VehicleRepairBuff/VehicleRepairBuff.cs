using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleRepairBuff : MonoBehaviour {

    [Header("Rotation speed of the buff.")]
    [SerializeField]
    private float _rotationSpeed;

    [Header("Amount of health to be repaired.")]
    [SerializeField]
    private float _repairAmount;

    private Transform _trans;

    void Awake()
    {
        _trans = GetComponent<Transform>();
    }

    void Update()
    {
        _trans.Rotate(Vector3.down * _rotationSpeed);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            //PlayerStats _playerData = col.gameObject.GetComponent<PlayerStats>();
            //_playerData.Health = _playerData.Health + _repairAmount;
            Destroy(gameObject);
        }
    }


}
