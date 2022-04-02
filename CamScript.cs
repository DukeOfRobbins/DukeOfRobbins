using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : UnityEngine.MonoBehaviour
{
    float panSpeed = 20f;
    float scrollSpeed = 150;
    float edgeOfScreen = 10f;

    public float minY = -250f;
    public float maxY =50f;
    public float minX = -150;
    public float maxX = 150f;
    public float minH = -30;
    public float maxH = 200;

    float minFov = 10;
    float maxFov = 60;
    public float fov = 50;

    private void Update()
    {
        Camera.main.fieldOfView = fov;
        Vector3 pos = transform.position;


                if (Input.mousePosition.y >= Screen.height - 20)
                {
                    pos.z += panSpeed * Time.deltaTime;
                }
                else if (Input.mousePosition.y <= edgeOfScreen)
                {
                    pos.z -= panSpeed * Time.deltaTime;
                }
                else if (Input.mousePosition.x >= Screen.width - edgeOfScreen)
                {
                    pos.x += panSpeed * Time.deltaTime;
                }
                else if (Input.mousePosition.x <= edgeOfScreen)
                {
                    pos.x -= panSpeed * Time.deltaTime;
                }
            else if (Input.GetKey(KeyCode.D))
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                pos.x -= panSpeed * Time.deltaTime;
            }

            else if (Input.GetKey(KeyCode.W))
                {
                    pos.z += panSpeed * Time.deltaTime;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                //if (pos.z > 10)
                {
                    pos.z -= panSpeed * Time.deltaTime;
                }
        }

            float Scroll = Input.GetAxis("Mouse ScrollWheel");
            fov -= (Scroll * scrollSpeed * Time.deltaTime);

            pos.y = Mathf.Clamp(pos.y, minY, maxY);
            pos.z = Mathf.Clamp(pos.z, minY, maxY);
            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            fov = Mathf.Clamp(fov, minFov, maxFov);
            pos.y = Mathf.Clamp(pos.y, minH, maxH);

            transform.position = pos;
        }

}


//float edgeSize = 50.0f;

//        if (Input.mousePosition.x > Screen.width + edgeSize* Time.deltaTime)
//{
//    transform.position.x
//        }


//        else if (Input.mousePosition.x<Screen.width - edgeSize* Time.deltaTime)
//        {
//            transform.position = new Vector3(-0.001f, 0, 0);
//        }

//{
//    //float speed = 0.2f;
//    float fov;
//    float minFov = 5;
//    float maxFov = 60;
//    //float minHoriz = 100;
//    //float maxHoriz = 100;

//    public int boundary = 0;
//    void Start()
//    {
//        //Start the Camera field of view at 30

//        fov = 30.0f;

//    }

//    void Update()

//    {


//        float speed = 50.0f;
//        if (Input.mousePosition.x > m_screenWidth)
//        {
//            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
//                                                                      Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
//        }
//        if (Input.GetAxis("Mouse Y") > 0)
//        {
//            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
//                                                                      Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
//            //Debug.Log(Input.mousePosition.x);
//        }

//        if (Input.GetAxis("Mouse Y") < 0)
//        {
//            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
//                                                                      Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
//        }









//    }

//}

////Horizontal and Vertical - KB arrow keys
//if (Input.GetAxis("Horizontal") > 0)
//{

//    GetComponent<Transform>().position = new Vector3(posx += 1, posy, posz);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
//    Debug.Log(posx);
//    //Debug.Log(fov);

//}

//else if (Input.GetAxis("Horizontal") < 0)
//{
//    GetComponent<Transform>().position = new Vector3(posx -= 1, posy, posz);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
//    //Debug.Log(transform.position);

//}

////Horizontal and Vertical - KB arrow keys
//if (Input.GetAxis("Vertical") > 0)
//{

//    GetComponent<Transform>().position = new Vector3(posx, posy, posz+=1);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
//    Debug.Log(posx);
//    //Debug.Log(fov);

//}

//else if (Input.GetAxis("Vertical") < 0)
//{
//    GetComponent<Transform>().position = new Vector3(posx, posy, posz);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
//    //Debug.Log(transform.position);

//}



//if (Input.GetAxis("Mouse X") > 0)
//{

//    GetComponent<Transform>().position = new Vector3(posx +1, posy, posz);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
//    Debug.Log(transform.position.x);

//}

//else if (Input.GetAxis("Mouse X") < 0)
//{
//    GetComponent<Transform>().position = new Vector3(posx -1, posy, posz);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal")  * speed, Input.GetAxis("Vertical") * speed);
//    //Debug.Log(transform.position);

//}

//if (Input.GetAxis("Vertical") > 0)
//{

//    GetComponent<Transform>().position = new Vector3(posx, posy, posz -= 1);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
//    //Debug.Log(transform.position);

//}

//else if (Input.GetAxis("Vertical") < 0)
//{
//    GetComponent<Transform>().position = new Vector3(posx, posy, posz += 1);
//    //transform.position += new Vector3(Input.GetAxis("Horizontal")  * speed, Input.GetAxis("Vertical") * speed);
//    //Debug.Log(transform.position);

//}



//float xscrollspeed = 10;
//float yscrollspeed = 10;
//float zscrollspeed = 10;

//Debug.Log(transform.position);

//if (Input.GetAxis("Mouse ScrollWheel") < 0 && (transform.position.x < 10))
//{
//    GetComponent<Transform>().position = new Vector3(transform.position.x + xscrollspeed, transform.position.y, transform.position.z);
//}
//else if (Input.GetAxis("Mouse ScrollWheel") > 0 && (transform.position.x < 30))
//{
//    GetComponent<Transform>().position = new Vector3(transform.position.x - xscrollspeed, transform.position.y, transform.position.z);
//}
//if (Input.GetAxis("Mouse ScrollWheel") > 0 && (transform.position.z < 1))
//{
//    GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + yscrollspeed, transform.position.z + zscrollspeed);
//}
//else if (Input.GetAxis("Mouse ScrollWheel") < 0 && (transform.position.z > 1))
//{
//    GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, transform.position.z - zscrollspeed);
//}
//if (Input.GetKey("up") && transform.position.y < 45)
//{
//    transform.position += new Vector3(0, 0.2f, 0);
//}
//else if (Input.GetKey("down") && transform.position.y > 5)
//{
//    transform.position += new Vector3(0, -2.5f, 0);
//}
//else if (Input.GetKey("right"))
//{
//    transform.Rotate(0, 0.5f, 0);
//}
//else if (Input.GetKey("left"))
//{
//    transform.Rotate(0, -0.5f, 0);
//}


//var fov = Camera.main.fieldOfView;

//float vtranslation = Input.GetAxis("Vertical") * speed;
//float htranslation = Input.GetAxis("Horizontal") * speed;

//vtranslation *= Time.deltaTime;
//htranslation *= Time.deltaTime;

//// Move translation along the object's z-axis
//transform.Translate(0, 0, vtranslation);

//// Rotate around our y-axis
//transform.Rotate(0, htranslation, 0);


//Mouse X and Mouse Y, mouse movement without button presses


//if (Input.GetAxis("Mouse X") > 20)
//{
//    transform.position += new Vector3(Input.GetAxis("Mouse X") * speed, 0.0f,
//                                Input.GetAxis("Mouse Y") * speed);
//}

//else if (Input.GetAxis("Mouse X") < -20)
//{
//    transform.position += new Vector3(Input.GetAxis("Mouse X") * speed, 0.0f,
//                                Input.GetAxis("Mouse Y") * speed);
//}



//{
//if (Input.GetAxis("Mouse ScrollWheel") < 0)
//{
//    fov += 4;
//    //Debug.Log(fov);
//}



//else if (Input.GetAxis("Mouse ScrollWheel") > 0)
//{
//    fov -= 4;
//    //Debug.Log(fov);
//}

    //else if (Input.GetKey("up"))
    //{
    //    transform.position += new Vector3(0, 0.2f, 0);
    //}


//    else if (Input.GetKey("right"))
//    {
//        transform.position += new Vector3(0.05f, 0, 0);
//    }

//    else if (Input.GetKey("left"))
//    {
//        transform.position += new Vector3(-0.05f, 0, 0);
//    }


//    else if (Input.GetKey("down"))
//    {
//        transform.position += new Vector3(0, -0.2f, 0);
//    }

