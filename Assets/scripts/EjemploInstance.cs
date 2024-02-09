using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploInstance : MonoBehaviour
{
    [SerializeField]
    GameObject gameObjectPrefab;

    [SerializeField]
    float height = 0.77f;
    [SerializeField]
    float minX = -9.7f;
    [SerializeField]
    float maxX = 9.66f;

    [SerializeField]
    Vector2 rangeZ = new Vector2(-9.9f, 9.9f);
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateHelmet();
        }
    }

    //otra manera de bucle for (le pondriamos createHelmet en el start las veces como cubos queremos)
    void CreateHelmet()
    {
        GameObject clone = Instantiate(gameObjectPrefab);
        clone.name = "TheCube";
        clone.transform.position = new Vector3(Random.Range(minX, maxX), height, Random.Range(rangeZ.x, rangeZ.y));
        //Para que la escala sea diferente
        /*clone.transform.localScale *= 4f;*/
    }


    //Otra manera de hacer un rango
    /*
    public class Range
    {
        [Tooltip("Minimo del rango")] //Para darle una ayuda al jugador cuando pase el raton por encima
        public float min;
        [Tooltip("Maximo del rango")]
        public float max;

        public Range(float minimum, float maximum)
        {
            this.min = minimum;
            this.max = maximum;
        }
        
    }
    */

    // Depuramos con el f9
    void Update()
    {
        
    }
}
