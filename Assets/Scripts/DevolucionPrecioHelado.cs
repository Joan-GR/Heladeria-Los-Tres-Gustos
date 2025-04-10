using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevolucionPrecioHelado : MonoBehaviour
{
    // Start is called before the first frame update
    public float gramos;
    public string gusto;
    float precioFinal;

    void Start()
    {
        if (gramos < 250)
        {
            Debug.Log("El peso del helado no es valido");
            return;
        }
        if (gramos > 3000)
        {
            Debug.Log("El peso del helado no es valido");
            return;
        }
        if (gusto == "DDL")
        {
            precioFinal = gramos / 1000 * 500;
        }
        else if (gusto == "CHO")
        {
            precioFinal = gramos / 1000 * 500;
        }
        else if (gusto == "FRU")
        {
            precioFinal = gramos / 1000 * 500 * 0.9f;
        }
        else
        {
            Debug.Log("El codigo ingresado no es valido");
            return;
        }
        Debug.Log("El precio de su helado es $" + precioFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
