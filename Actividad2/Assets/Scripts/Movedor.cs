using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedor : MonoBehaviour
{
    public Transform[] elemento;
    public bool objeto1 = false;
    public bool objeto2 = false;
    public bool objeto3 = false;
    public bool objeto4 = false;


    void Start()
    {
        
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            objeto1 = true;
            objeto2 = false;
            objeto3 = false;
            objeto4 = false;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            objeto1 = false;
            objeto2 = true;
            objeto3 = false;
            objeto4 = false;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            objeto1 = false;
            objeto2 = false;
            objeto3 = true;
            objeto4 = false;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            objeto1 = false;
            objeto2 = false;
            objeto3 = false;
            objeto4 = true;
        }



                if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && objeto1 == true)
                {
                    elemento[0].transform.position -= Vector3.left / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && objeto1 == true)
                {
                    elemento[0].transform.position -= Vector3.right / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && objeto1 == true && elemento[0].position.y > 0)
                {
                    elemento[0].transform.position += Vector3.down / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && objeto1 == true)
                {
                    elemento[0].transform.position += Vector3.up / 2;
                }

                else if (Input.GetKeyDown(KeyCode.Z) && objeto1 == true)
                {
                    elemento[0].transform.position += Vector3.forward / 2;
                }

                else if (Input.GetKeyDown(KeyCode.X) && objeto1 == true)
                {
                    elemento[0].transform.position += Vector3.back / 2;
                }

                //...

                else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && objeto2 == true)
                {
                    elemento[1].transform.position -= Vector3.left / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && objeto2 == true)
                {
                    elemento[1].transform.position -= Vector3.right / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && objeto2 == true && elemento[1].position.y > 0)
                {
                    elemento[1].transform.position += Vector3.down / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && objeto2 == true)
                {
                    elemento[1].transform.position += Vector3.up / 2;
                }

                else if (Input.GetKeyDown(KeyCode.Z) && objeto2 == true)
                {
                    elemento[1].transform.position += Vector3.forward / 2;
                }

                else if (Input.GetKeyDown(KeyCode.X) && objeto2 == true)
                {
                    elemento[1].transform.position += Vector3.back / 2;
                }

                //...

                else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && objeto3 == true)
                {
                    elemento[2].transform.position -= Vector3.left / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && objeto3 == true)
                {
                    elemento[2].transform.position -= Vector3.right / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && objeto3 == true && elemento[2].position.y > 0)
                {
                    elemento[2].transform.position += Vector3.down / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && objeto3 == true)
                {
                    elemento[2].transform.position += Vector3.up / 2;
                }

                else if (Input.GetKeyDown(KeyCode.Z) && objeto3 == true)
                {
                    elemento[2].transform.position += Vector3.forward / 2;
                }

                else if (Input.GetKeyDown(KeyCode.X) && objeto3 == true)
                {
                    elemento[2].transform.position += Vector3.back / 2;
                }

                //...


                else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && objeto4 == true)
                {
                    elemento[3].transform.position -= Vector3.left / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && objeto4 == true)
                {
                    elemento[3].transform.position -= Vector3.right / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && objeto4 == true && elemento[3].position.y > 0)
                {
                    elemento[3].transform.position += Vector3.down / 2;
                }

                else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && objeto4 == true)
                {
                    elemento[3].transform.position += Vector3.up / 2;
                }

                else if (Input.GetKeyDown(KeyCode.Z) && objeto4 == true)
                {
                    elemento[3].transform.position += Vector3.forward / 2;
                }

                else if (Input.GetKeyDown(KeyCode.X) && objeto4 == true)
                {
                    elemento[3].transform.position += Vector3.back / 2;
                }

                //...
    }

}
