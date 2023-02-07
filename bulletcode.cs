using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}

/*THIS IS A COMMENT script moves bullet up by y using speed. transform.up moves the bullet up (using the Y axis*/
