using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

   
{
    [SerializeField] float speed = 1;
    // Update is called once per frame
    void Update()
    {
        //move sphere forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
