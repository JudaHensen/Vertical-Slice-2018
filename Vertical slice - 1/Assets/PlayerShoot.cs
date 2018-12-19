using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject projectile;
    public GameObject spawnPosition;

    public void Shoot()
    {
        GameObject laser = Instantiate(projectile, spawnPosition.transform.position, Quaternion.identity);
        laser.transform.rotation = transform.rotation;
    }

}
