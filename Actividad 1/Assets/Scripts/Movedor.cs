using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedor : MonoBehaviour
{
    public Transform[] elemento;

    void Start()
    {

    }


    void Update()
    {



        for (int i = 0; i < elemento.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                elemento[0].position += Vector3.right;
            }

            else if (Input.GetKeyDown(KeyCode.X))
            {
                elemento[1].position += Vector3.right;
            }

            else if (Input.GetKeyDown(KeyCode.C))
            {
                elemento[2].position += Vector3.right;
            }

            else if (Input.GetKeyDown(KeyCode.V))
            {
                elemento[3].position += Vector3.right;

                if (elemento[3].position.x > 4 || elemento[3].position.x < -4)
                {
                    elemento[3].transform.position = new Vector3(0, 0, 0);
                }
            }

            else if (Input.GetKeyDown(KeyCode.B))
            {
                elemento[4].position += Vector3.right;

                if (elemento[4].position.x > 4 || elemento[4].position.x < -4)
                {
                    elemento[4].transform.position = new Vector3(0, 0, 0);
                }
            }

            //.................................................

            else if (Input.GetKeyDown(KeyCode.Q))
            {
                elemento[0].position += Vector3.left;
            }

            else if (Input.GetKeyDown(KeyCode.W))
            {
                elemento[1].position += Vector3.left;
            }

            else if (Input.GetKeyDown(KeyCode.E))
            {
                elemento[2].position += Vector3.left;
            }

            else if (Input.GetKeyDown(KeyCode.R))
            {
                elemento[3].position += Vector3.left;

                if (elemento[3].position.x > 4 || elemento[3].position.x < -4)
                {
                    elemento[3].transform.position = new Vector3(0, 0, 0);
                }
            }

            else if (Input.GetKeyDown(KeyCode.T))
            {
                elemento[4].position += Vector3.left;

                if (elemento[4].position.x > 4 || elemento[4].position.x < -4)
                {
                    elemento[4].transform.position = new Vector3(0, 0, 0);
                }
            }

            //..................................................

            else if (Input.GetKeyDown(KeyCode.A))
            {
                elemento[0].position += Vector3.up;
            }

            else if (Input.GetKeyDown(KeyCode.S))
            {
                elemento[1].position += Vector3.up;
            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                elemento[2].position += Vector3.up;
            }

            else if (Input.GetKeyDown(KeyCode.F))
            {
                elemento[3].position += Vector3.up;

                if (elemento[3].position.y > 4 || elemento[3].position.y < -4)
                {
                    elemento[3].transform.position = new Vector3(0, 0, 0);
                }
            }

            else if (Input.GetKeyDown(KeyCode.G))
            {
                elemento[4].position += Vector3.up;

                if (elemento[4].position.y > 4 || elemento[4].position.y < -4)
                {
                    elemento[4].transform.position = new Vector3(0, 0, 0);
                }
            }

            //.........................................

            else if (Input.GetKeyDown(KeyCode.Space))
            {
                elemento[i].transform.position = new Vector3(0, 0, 0);
            }

            //.........................................
            
        }
    }
}