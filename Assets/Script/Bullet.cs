using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0f, 0f, speed, ForceMode.Impulse);
        Invoke("DestroyBall", 15f);
    }

    public void Weight(float weight)
    {
        rb.mass = weight;
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
