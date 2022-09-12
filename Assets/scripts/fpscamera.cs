using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpscamera : MonoBehaviour
{
    private new Transform camera;
    public Vector2 sensibility;
    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float horz = Input.GetAxis("Mouse X");
       float ver = Input.GetAxis("Mouse Y");

       if (horz != 0){
            transform.Rotate(Vector3.up * horz * sensibility.x);
       }
       if (ver != 0){
            float angle= (camera.localEulerAngles.x - ver * sensibility.y + 360) % 360;
            if(angle > 180){angle -= 360;}
            angle = Mathf.Clamp(angle, -80, 80);
            camera.localEulerAngles = Vector3.right * angle;
       }

    }
}
