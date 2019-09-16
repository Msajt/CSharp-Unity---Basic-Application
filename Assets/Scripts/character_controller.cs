using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character_controller : MonoBehaviour{

    public float minY, maxY;
    public int hp, points;
    bool pegou;
    public GameObject coin;
    public Text points_text, hp_text;

    void Start(){
        Instantiate(coin, coin.transform.position, coin.transform.rotation);
        pegou = false;
        points_text.text = points.ToString();
        hp_text.text = hp.ToString();
    }

    void Update(){
        Move();
    }
    // Essa função fará com que o personagem se mova
    void Move(){
        transform.position = new Vector2(0.0f ,Mathf.Clamp(transform.position.y, minY, maxY)); // Limita a posição
        if (Input.GetKeyDown(KeyCode.W)){ // A função só será verdadeira quando você clicar no botão
            transform.Translate(new Vector2(0, 2)); // Muda a posição
        }
        if (Input.GetKeyDown(KeyCode.S)){
            transform.Translate(new Vector2(0, -2));
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            hp--;
            hp_text.text = hp.ToString();
            if (hp <= 0) Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            pegou = true;
        }
        if(collision.gameObject.tag == "Finish")
        {
            if (pegou)
            {
                points++;
                points_text.text = points.ToString();
                Instantiate(coin, coin.transform.position, coin.transform.rotation);
                pegou = false;
            }
        }
    }
}
