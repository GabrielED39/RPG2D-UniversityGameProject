using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject txtDialogo;
    public int numVistas;

    public Sprite txt1, txt2;


    void Start()
    {
        txtDialogo.SetActive(false);
        numVistas = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "Player")
        {
            txtDialogo.SetActive(true);
            EscribeDialogo();
            numVistas++;
        }
        
    }

    private void EscribeDialogo(){
        switch (numVistas){
            case 0:
                txtDialogo.GetComponent<SpriteRenderer>().sprite = txt1;
                break;
            case 1:
                txtDialogo.GetComponent<SpriteRenderer>().sprite = txt2;
                break;
        }
    }
}