using UnityEngine;

public class PlayerStats : MonoBehaviour {
    
    private float maxHealth = 100;
    float health;

    private float collisionCoolDown = 1f;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        collisionCoolDown -= Time.deltaTime;
    }

    private void OnCollision(Collision collision)
    {
        if (collision.transform.tag == "Wall" && collisionCoolDown <= 0)
        {
            health -= 25;
            collisionCoolDown = 1f;
        }
    }

    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            if (value < 0)
            {
                Die();
            } else if (value > maxHealth)
            {
                health = maxHealth;
            }
            else health = value;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Border")
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("We ded boi's");
        Destroy(gameObject);
    }

}