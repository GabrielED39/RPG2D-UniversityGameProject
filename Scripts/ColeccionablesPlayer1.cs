using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColeccionablesPlayer1 : MonoBehaviour
{
    private GameObject PLAYER;
    public static string objAColeccionar;
    private Inventario inventario;

    void Start()
    {
        PLAYER = GameObject.Find("PLAYER");
        objAColeccionar = "";
        inventario = FindObjectOfType<Inventario>();
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "vida")
        {
            VidasPlayer.vida++;
            PLAYER.GetComponent<VidasPlayer>().DibujaVida(VidasPlayer.vida);
            Destroy(obj.gameObject);
        }
        if (obj.tag == "mana")
        {
            //aumenta mana
            Destroy(obj.gameObject);
        }
        if (obj.tag == "Moneda")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "Gema")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "libro1"){
            AplicarCambios(obj);
        }
        if (obj.tag == "libro2")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "libro3")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "libro4")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "libro5")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "llave")
        {
            AplicarCambios(obj);
        }
        if (obj.tag == "galleta")
        {
            AplicarCambios(obj);
        }
    }

    private void AplicarCambios(Collider2D obj)
    {
        objAColeccionar = obj.tag;
        inventario.EscribeEnArreglo();
        Destroy(obj.gameObject);

    }
}
