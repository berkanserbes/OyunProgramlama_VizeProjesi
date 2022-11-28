using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control2Sc : MonoBehaviour, IControl
{
    public float Speed {
        get {return _speed;}
        set {_speed = value;}
    }
    public float Jump {
        get {return _jump;}
        set {_jump = value;}
    }
    public float MaxSpeed{
        get {return _maxSpeed;}
        set {_maxSpeed = value;}
    }
    public float _speed;
    public float _jump; 
    public float _maxSpeed;
    private float horizontal_speed;
    private float vertical_speed;
    private PlayerSc playerSc;
    private Rigidbody rb;
    public GameObject bullet;
    public GameObject location;
    private Transform playerCamera;
    public Transform cubeDoor;

     void Start(){
        rb = GetComponent<Rigidbody>();
        playerSc = GetComponent<PlayerSc>();
        InitCamera();
        //LookAtCube();
    }

    void InitCamera(){
        playerCamera = this.gameObject.transform.GetChild(0).transform;
        location.transform.position = new Vector3(cubeDoor.position.x, cubeDoor.position.y, location.transform.position.z);
        playerCamera.position = new Vector3(cubeDoor.position.x, cubeDoor.position.y, playerCamera.transform.position.z);
        playerCamera.localEulerAngles = new Vector3(0f, 0f, 0f);
    }

    void FixedUpdate(){
        PlayerControl();
    }

    void PlayerControl(){
        switch(name){
            case "P1":
                P1CharacterControl();
                P1FireControl();
                break;
            case "P2":
                P2CharacterControl();
                P2FireControl();
                break;
            default:
                break;
        }
    }

    void P1CharacterControl(){
        Vector3 velocity = rb.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        if(Mathf.Abs(localVelocity.x) <= _maxSpeed && Input.GetAxis("P1Horizontal") != 0)
        {
            horizontal_speed = Input.GetAxis("P1Horizontal") * _speed;
            transform.Rotate(0f, horizontal_speed * Time.deltaTime * 2, 0f, Space.Self);
        }
        /*if(Mathf.Abs(localVelocity.z) <= _maxSpeed && Input.GetAxis("P1Vertical") != 0)
        {
            vertical_speed = Input.GetAxis("P1Vertical") * _speed;
            rb.AddForce(transform.forward * vertical_speed);
        }*/
        
        if(Input.GetAxisRaw("P1Jump") != 0 && playerSc.onGround){
            Debug.Log("Jump calisti.");
            rb.AddForce(Vector3.up * _jump);
        }
    }

    void P2CharacterControl(){
        Vector3 velocity = rb.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
         if(Mathf.Abs(localVelocity.x) <= _maxSpeed && Input.GetAxis("P2Horizontal") != 0)
        {
            horizontal_speed = Input.GetAxis("P2Horizontal") * _speed;
            rb.AddForce(transform.right * horizontal_speed);
        }
        if(Mathf.Abs(localVelocity.z) <= _maxSpeed && Input.GetAxis("P2Vertical") != 0)
        {
            vertical_speed = Input.GetAxis("P2Vertical") * _speed;
            rb.AddForce(transform.forward * vertical_speed);
        }
        
        if(Input.GetAxisRaw("P2Jump") != 0 && playerSc.onGround){
            Debug.Log("Jump calisti.");
            rb.AddForce(Vector3.up * _jump);
        }
    }

    void P1FireControl(){
        if(Input.GetAxisRaw("P1Fire") > 0){
            Debug.Log("Left ctrl basildi.");
            GameObject bulletRef = Instantiate(bullet, location.transform.position, Quaternion.identity) as GameObject;
            Vector3 forward = location.transform.forward;
            BulletSc bulletSc = bulletRef.gameObject.GetComponent<BulletSc>();
            bulletSc.forward = forward;
        }
    }

    void P2FireControl(){
        if(Input.GetAxisRaw("P2Fire") > 0){
            GameObject bulletRef = Instantiate(bullet, location.transform.position, Quaternion.identity) as GameObject;
            Vector3 forward = location.transform.forward;
            BulletSc bulletSc = bulletRef.gameObject.GetComponent<BulletSc>();
            bulletSc.forward = forward;
        }
    }


}
