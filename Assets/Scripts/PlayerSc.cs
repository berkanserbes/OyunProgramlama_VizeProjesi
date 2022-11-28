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

    public bool isParkourFinishedP1 = false;
    public bool isParkourFinishedP2 = false;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
        onGround = false;
        gameSc = game.GetComponent<GameSc>(); 
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
            isParkourFinishedP1 = true;
            Debug.Log("isParkourFinishedP1 set edildi : " + isParkourFinishedP1);
            Debug.Log("playerSc.isParkourFinishedP1 Calisti");
            this.gameObject.transform.position = new Vector3(150.05f,236.59f,0);
            Debug.Log("Player position: " + this.gameObject.transform.position);
        }
        if(other.tag == "P2LastLoop") {
            isParkourFinishedP2 = true;
            Debug.Log("isParkourFinishedP2 set edildi : " + isParkourFinishedP2);
        }
    }
}
