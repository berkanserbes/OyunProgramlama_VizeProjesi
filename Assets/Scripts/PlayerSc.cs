using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSc : MonoBehaviour
{
    
    public GameObject game; //Oyun bilgilerini tutan Empty GameObject
    private GameSc gameSc; //Oyun bilgilerini tutan Script
    public Rigidbody rb; //Player'in Rigidbody component'i
    public bool onGround; //Tag'i "Floor" olan objeyle temas ettiginde degeri true olur
    public float mass; //Kutle
    public GameObject bullet;
    public GameObject location;

    public IControl control;
    public GameObject player1Win;
    public GameObject player2Win;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
        onGround = false;
        gameSc = game.GetComponent<GameSc>(); 
        player1Win.SetActive(false);
        player2Win.SetActive(false);
        
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Floor"){
            onGround = true;
        }
    }

    void OnCollisionStay(Collision other){
        if(!onGround && other.gameObject.tag == "Floor"){
            onGround = true;
        }
    }

    void OnCollisionExit(Collision other){
        if(onGround){
            onGround = false;
        }
    }

     void OnTriggerEnter(Collider other) {
        if(other.tag == "P1LastLoop") {
            player1Win.SetActive(true);
            Time.timeScale = 0f;
        }
        
        else if(other.tag == "P2LastLoop") {
            player2Win.SetActive(true);  
            Time.timeScale = 0f;
        } 
    }
}