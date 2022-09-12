using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controljugador : MonoBehaviour
{
    private CharacterController characterController;
    public float velocidad;
    Rigidbody miRigidbody;
    Vector3 posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        miRigidbody = GetComponent <Rigidbody>();
        posicionInicial = transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxisRaw("Vertical");
        float horz = Input.GetAxisRaw("Horizontal");
        if(horz != 0 || ver != 0 ){
            Vector3 motion = (transform.forward * ver + transform.right * horz).normalized * velocidad;
            miRigidbody.velocity = motion;
        }
        else {
            miRigidbody.velocity = Vector3.zero;
        }

    }
}
