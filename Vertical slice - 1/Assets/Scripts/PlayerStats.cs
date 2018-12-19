using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    [SerializeField] private GameObject healthbar;
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
        if (health <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Wall" && collisionCoolDown <= 0)
        {
            health -= 25;
            collisionCoolDown = 1f;
            healthbar.GetComponent<Healthbar>().SetCurrent(health);
            print(health);
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
            }
            else if (value > maxHealth)
            {
                health = maxHealth;
            }
            else health = value;

            healthbar.GetComponent<Healthbar>().SetCurrent(health);
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
        //Destroy(gameObject);
        SceneManager.LoadScene("Game");
    }

}