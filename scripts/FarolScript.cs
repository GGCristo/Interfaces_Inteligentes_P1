using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarolScript : MonoBehaviour
{
    private int ID = 3;
    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Hola soy el farol con ID: " + ID);   
    }

    // Update is called once per frame
    void Update()
    {
        print("ID: " + ID + " ,Nombre: " + this.name + " ,Tag: " + this.tag + " ,Contador: " + contador);
        contador++;
    }
}
