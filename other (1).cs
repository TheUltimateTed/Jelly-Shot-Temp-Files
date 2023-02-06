using UnityEngine;

public class TopDownShooter : MonoBehaviour
{
    public Transform player;
    public GameObject bulletFab;
    public float FR = 0.5f;
    public float NF = 0.0f;

    void Update()
    {
        if (Input.GetMouseDown() && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, player.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
    }
}


