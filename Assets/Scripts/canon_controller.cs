using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon_controller : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletPosition;
    public float BulletSpeed;
    public int BulletTrigger;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 50) == BulletTrigger)
        {
            GameObject newBullet = Instantiate(Bullet, BulletPosition.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * BulletSpeed;
        }
    }
}
