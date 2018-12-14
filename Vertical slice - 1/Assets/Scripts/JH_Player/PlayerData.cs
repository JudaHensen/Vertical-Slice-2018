using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    [Header("Player minimum & maximum health")]
    [SerializeField] private float _minHealth;
    [SerializeField] private float _maxHealth;
    private float _health;

    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value < 0)
            {
                _health = 0;
                Debug.Log("die");
            }
            else _health = value;
        }
    }
}
