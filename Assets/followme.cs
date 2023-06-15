using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class followme : MonoBehaviour
{
    public Transform objectTofollow;
    public Vector3 offset;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectTofollow.position.y - target.position.y < 0.06)
         {
           transform.position = objectTofollow.position + offset;

        }

        //print(objectTofollow.position.y - target.position.y);
    }
}
