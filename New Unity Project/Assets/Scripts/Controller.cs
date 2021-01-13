using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float carSpeed = 12;
    public float turnAngle = 02/10;
    public  Vector3 cameraoffset = new Vector3(0, 6, -10);
    public new Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game start");
    }
    /*
    public Transform pivot;
    public float speed;
    public Vector3 axis;

    void Update()
    {
        transform.RotateAround(pivot.position, axis, speed * Time.deltaTime);
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {

        camera.transform.position = transform.position + cameraoffset ;
        if (Input.GetButton("Liftdown"))
        {
            transform.Rotate(-1, 0, 0);
        }
        // movement of car
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward*Time.fixedDeltaTime*carSpeed);
            //camera.transform.position = transform.position + cameraoffset;
            if (Input.GetButton("Liftoff"))
            {
                transform.Rotate(2, 0, 0);
            }


        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward*Time.fixedDeltaTime*-carSpeed);
            //camera.transform.position = transform.position + cameraoffset;
        }
        // rotation of car

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,-turnAngle , 0);
           // camera.transform.Rotate(new Vector3(0, -turnAngle, 0) + transform.Rotate(0,0,0), Time.deltaTime) ; //transform.Rotate(0,-turnAngle,0) 
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, turnAngle, 0);
        }
    }
}
