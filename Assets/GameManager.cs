using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject writeArtifact;
    GameObject readArtifact;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 forward = transform.TransformDirection(Vector3.forward) * 30;
            Debug.DrawRay(transform.position, forward, Color.green);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.name == "writeArtifact")
                {
                    Instantiate(writeArtifact, hit.point, Quaternion.identity);
                    print("Leave a message!");
                }

                else if(hit.transform.name == "readArtifact")
                {
                    Instantiate(writeArtifact, hit.point, Quaternion.identity);
                    print("Read a message!");
                }

            }

        }
    }
}

