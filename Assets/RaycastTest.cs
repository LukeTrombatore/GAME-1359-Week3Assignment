using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, Vector3.down);

        Debug.DrawLine(r.origin, r.origin + (Vector3.down * 1));

        RaycastHit hit;

        if (Physics.Raycast(r, out hit, 1))
        {
            if (hit.transform != null)
            {

                Debug.Log(hit.transform.name);
                
                //Checking to see if the object hit has the specific script called "GroundInfo"
                if (hit.transform.GetComponent<GroundInfo>() != null)
                {
                    Debug.Log(hit.transform.GetComponent<GroundInfo>().value);

                }
            }
        }
    }
}
