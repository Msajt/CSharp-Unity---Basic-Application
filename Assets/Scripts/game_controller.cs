using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_controller : MonoBehaviour{
    public GameObject coin, personagem, valida;
    public Transform coinPosition;
    public int points, life;

    void Start(){
        Instantiate(coin, coinPosition.position, coinPosition.rotation);
        points = 0;
        life = 5;
    }

    void Update(){
        
    }
}
