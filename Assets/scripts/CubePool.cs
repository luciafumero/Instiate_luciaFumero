using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePool : MonoBehaviour
{
    [SerializeField]
    int maximumElements = 10;
    [SerializeField]
    GameObject futureCreatedObject;

    private Stack<GameObject> pool; //donde se guardan los objetos

    public static CubePool instance;

    private void Awake()
    {
        if (CubePool.instance == null) 
        { 
            instance = this; 
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        SetUpPool(); 
    }


    void SetUpPool()
    {
        pool = new Stack<GameObject>();
        GameObject createdCube = null; //reasignar valores de un objeto en vez de crear uno nuevo
        
        for (int i = 0; i < maximumElements; i++)
        {
            createdCube = Instantiate(futureCreatedObject);
            createdCube.SetActive(false);
            pool.Push(createdCube);
        }   
    }
    public GameObject GetObject()
    {
        GameObject Cube = null;

        if (pool.Count == 0)
        {
            Cube = Instantiate(futureCreatedObject);
            
        }
        else
        {
            Cube = pool.Pop();
            Cube.SetActive(true);
        }
        return Cube;
    }

    /* otra manera para get Object
    if (pool.Count == 0)
        {
            GameObject createdCube = Instantiate(futureCreatedObject);
            return createdCube;
        }
    else
       {
            GameObject Cube = pool.Pop();
            Cube.SetActive(true);
       }
    */

    public void ReturnObject(GameObject returnedCube)
    { 
        pool.Push(returnedCube); 
        returnedCube.SetActive(false);
    }


}
