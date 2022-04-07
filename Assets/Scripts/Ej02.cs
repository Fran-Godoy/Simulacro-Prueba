using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public float gasto1, gasto2, gasto3;
    public float dinero;
    // Start is called before the first frame update
    void Start()
    {
        float total = gasto1 + gasto2 + gasto3;
        if (total > dinero)
        {
           Debug.Log("Te faltan " + (total - dinero) + " pesos");
        }
        else
        {
            Debug.Log("Te sobran " + (dinero - total) + " pesos");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
