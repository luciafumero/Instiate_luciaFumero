using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    CubePool pool;

    void Start()
    {
        pool = GetComponent<CubePool>();
    }

    void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            GameObject cube = pool.GetObject(); 

            if(cube.GetComponent<Rigidbody>() == null )
            {
                cube.AddComponent<Rigidbody>();
            }
            cube.transform.position = transform.position;
            cube.GetComponent<Rigidbody>().velocity = Vector3.zero;
            cube.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 18f, 0f), ForceMode.Impulse);
        }
       
    }
}
