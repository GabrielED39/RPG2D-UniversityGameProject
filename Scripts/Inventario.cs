using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    private bool muestraInventario;
    public GameObject goInvetario;
    [SerializeField] private string[] valoresInventario; // ""-Sin elemento, string elemento
    private int numGemas, numMonedas, numPocionesRojas, numPocionesAzules;
    Button boton;
    public Sprite Moneda, MedKit, Gema, cerveza, escudo, galleta, libro1, libro2, libro3, libro4, libro5, llave, llave2, espada, espada2, hacha, pan, pergamino, pergamino2, pergamino3, pollo, contenedor;


    void Start()
    {
        muestraInventario = false;
        BorraArreglo();
        numGemas = 0;
        numMonedas = 0;
        numPocionesAzules = 0;
        numPocionesRojas = 0;
    }

    public void StatusInventario()
    {
        if (muestraInventario)
        {
            muestraInventario = false;
            goInvetario.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            
            muestraInventario = true;
            goInvetario.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void EscribeEnArreglo()
    {
        if(VerificaEnArreglo() == -1) //No esta en el inventario
        {
            for(int i = 0; i < valoresInventario.Length; i++)
            {
                if(valoresInventario[i] == "")
                {
                    valoresInventario[i] = ColeccionablesPlayer1.objAColeccionar;
                    DibujaElementos(i);
                    break;
                }
            }
        }
        else
        {
            DibujaElementos(VerificaEnArreglo());
        }
    }

    private int VerificaEnArreglo()
    {
        int pos = -1;
        for(int i = 0; i < valoresInventario.Length; i++)
        {
            if(valoresInventario[i] == ColeccionablesPlayer1.objAColeccionar)
            {
                pos = i;
                break;
            }
        }
        return pos;
    }

    public void DibujaElementos(int pos)
    {
        StatusInventario();
        boton = GameObject.Find("elemento ("+pos+")").GetComponent<Button>();
        switch (ColeccionablesPlayer1.objAColeccionar)
        {
            case "Moneda":
                contenedor = Moneda;
                numMonedas++;
                boton.GetComponentInChildren<Text>().text = "x" + numMonedas.ToString();
                break;
            case "MedKit":
                contenedor = MedKit;
                break;
            case "Gema":
                contenedor = Gema;
                numGemas++;
                boton.GetComponentInChildren<Text>().text = "x" + numGemas.ToString();
                break;
            case "cerveza":
                contenedor = cerveza;
                break;
            case "escudo":
                contenedor = escudo;
                break;
            case "galleta":
                contenedor = galleta;
                break;
            case "libro1":
                contenedor = libro1;
                break;
            case "libro2":
                contenedor = libro2;
                break;
            case "libro3":
                contenedor = libro3;
                break;
            case "libro4":
                contenedor = libro4;
                break;
            case "libro5":
                contenedor = libro5;
                break;
            case "llave":
                contenedor = llave;
                break;
            case "llave2":
                contenedor = llave2;
                break;
            case "espada":
                contenedor = espada;
                break;
            case "espada2":
                contenedor = espada2;
                break;
            case "hacha":
                contenedor = hacha;
                break;
            case "pan":
                contenedor = pan;
                break;
            case "pergamino":
                contenedor = pergamino;
                break;
            case "pergamino2":
                contenedor = pergamino2;
                break;
            case "pergamino3":
                contenedor = pergamino3;
                break;
            case "pollo":
                contenedor = pollo;
                break;
        }
        boton.GetComponent<Image>().sprite = contenedor;
    }

    private void BorraArreglo()
    {
        for(int i = 0; i < valoresInventario.Length; i++)
        {
            valoresInventario[i] = "";
        }
    }

   
}
 