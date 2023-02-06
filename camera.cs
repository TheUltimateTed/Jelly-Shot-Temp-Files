using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float panSpeed = .5f;

    new Camera camera;

    public float maxX;
    public float maxZ;
    public float minX;
    public float minZ;

    void Start()
    {
        camera = GetComponent<Camera>();
      

    }

    public void Update()
    {

        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {

            Vector3 rightMovement = Vector3.right * panSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
            Vector3 upMovement = Vector3.forward * panSpeed * Time.deltaTime * Input.GetAxis("Vertical");


            Vector3 newPosition = camera.transform.position + rightMovement + upMovement;
            

            if (newPosition.x > maxX)
            {

                newPosition.x = maxX;

            }

            if (newPosition.x < minX)
            {

                newPosition.x = minX;

            }

            if (newPosition.z > maxZ)
            {

                newPosition.z = maxZ;

            }

            if (newPosition.z < minZ)
            {

                newPosition.z = minZ;

            }

            camera.transform.position = newPosition;

        }

    }
    
}