using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletFab;
    public float BuSp = 20f;

    void Update()
    {
        if (Input.GetMouseDown())
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}