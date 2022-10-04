using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elemento2 : MonoBehaviour
{
    public Color color;
    public Color colorCanvi;
    public MeshRenderer meshRenderer;


    void Start()
    {
        meshRenderer.material.color = color;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            meshRenderer.material.color = colorCanvi;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            meshRenderer.material.color = color;
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}