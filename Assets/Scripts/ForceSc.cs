using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSc : MonoBehaviour
{
    public enum DirectionType{
        Forward, Up, Right
    }

    public GameObject player;

    public DirectionType direction;
    public float forceMagnitude;

    private Vector3 force;

    // Start is called before the first frame update
    void Start()
    {
        switch(direction){
            case DirectionType.Forward:
            Debug.Log("Forward");
                force = player.transform.forward;
            break;
            case DirectionType.Up:
            Debug.Log("Up");
                force = player.transform.up;
            break;
            case DirectionType.Right:
            Debug.Log("Right");
                force = player.transform.right;
            break;
            default:
                Debug.Log("Hata!");
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider other){
        //playerScript.maxSpeed = forceMagnitude;
    }

    void OnTriggerStay(Collider other){
        other.attachedRigidbody.AddForce(force * forceMagnitude);
    }

    void OnTriggerExit(Collider other){

    }
}
