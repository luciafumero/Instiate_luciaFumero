using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    float time = 0.0f;
    [SerializeField]
    float lifeTime = 2f;

    void Update()
    {
        time += Time.deltaTime;
        if (time > lifeTime)
        {
            this.gameObject.SetActive(false);
            CubePool.instance.ReturnObject(this.gameObject);
        }
    }

    void OnEnable()
    {
        time = 0.0f;
    }
}
