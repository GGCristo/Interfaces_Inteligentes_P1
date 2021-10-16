using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzScript : MonoBehaviour
{
    private int ID = 6;
    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
         print("Hola soy la luz general con ID: " + ID);
    }

    // Update is called once per frame
    void Update()
    {
        print("ID: " + ID + " ,Nombre: " + this.name + " ,Tag: " + this.tag + " ,Contador: " + contador);
        contador++;
    }
}
