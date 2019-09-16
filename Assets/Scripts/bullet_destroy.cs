using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_destroy : MonoBehaviour{
    public GameObject bullet;
    public float timer;

    void Update(){
        timer -= Time.deltaTime;
        if (timer <= 0) Destroy(gameObject);
    }
}
