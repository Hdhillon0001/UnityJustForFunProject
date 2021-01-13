using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 12.0f;
    public float speedTurn = 6.1f;
    public new Camera camera;
    public Vector3 offset = new Vector3(0, 5,-7);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //Move the car foward
       // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        camera.transform.position = transform.position + offset;
        //car controller

        if (Input.GetKey(KeyCode.UpArrow))
            {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //transform.Rotate(0, speedTurn, 0);
                transform.Rotate(Vector3.right, speedTurn);

                camera.transform.Rotate(0, 1/10, 0)  ;
                ;

                // transform.Translate(Vector3.right * Time.deltaTime * speedTurn);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                // transform.Rotate(0, -speedTurn, 0);
                transform.Rotate(Vector3.right,-speedTurn);
                camera.transform.Rotate(0, -1/10, 0);

                //  transform.Translate(Vector3.left * Time.deltaTime * speedTurn);
            }
        }
         if (Input.GetKey(KeyCode.DownArrow)) 
           {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, speedTurn, 0);

                // transform.Translate(Vector3.right * Time.deltaTime * speedTurn);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -speedTurn, 0);
                //  transform.Translate(Vector3.left * Time.deltaTime * speedTurn);
            }
        }

        
    }
}
