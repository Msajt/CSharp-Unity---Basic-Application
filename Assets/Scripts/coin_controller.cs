using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_controller : MonoBehaviour{
    public int coin_speed;
    void Start(){
        
    }

    void Update(){
        coin_rotation();
    }

    void coin_rotation(){
        transform.Rotate(new Vector3(0, coin_speed, 0));
    }
}
