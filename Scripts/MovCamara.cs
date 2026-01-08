using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Camera camara;

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "portal")
        {
            Vector3 posicioncamara = new Vector3(21f, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(12.3f, -1.34f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal1")
        {
            Vector3 posicioncamara = new Vector3(0, 13.02f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(0.45f, 8.71f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal2")
        {
            Vector3 posicioncamara = new Vector3(0, 13.02f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-4.46f, 8.7f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal3")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-4.54f, 4.45f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal4")
        {
            Vector3 posicioncamara = new Vector3(0, 24.98f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(3.51f, 20.93f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal5")
        {
            Vector3 posicioncamara = new Vector3(20.93f, 12.92f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(12.79f, 10.87f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal6")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(0.51f, 4.33f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal7")
        {
            Vector3 posicioncamara = new Vector3(0, 13.02f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(3.46f, 16.55f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal8")
        {
            Vector3 posicioncamara = new Vector3(20.98f, 25.02f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(12.87f, 24.75f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal9")
        {
            Vector3 posicioncamara = new Vector3(0, 24.98f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(8.3f, 24.65f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal10")
        {
            Vector3 posicioncamara = new Vector3(21, 13, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(24.51f, 16.5f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal11")
        {
            Vector3 posicioncamara = new Vector3(21, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(22.42f, 4.29f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal12")
        {
            Vector3 posicioncamara = new Vector3(20.98f, 25.02f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(24.46f, 20.93f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal13")
        {
            Vector3 posicioncamara = new Vector3(0, 13.02f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(8.26f, 10.83f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal14")
        {
            Vector3 posicioncamara = new Vector3(41f, 13f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(32.7f, 14.8f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal15")
        {
            Vector3 posicioncamara = new Vector3(41f, 0f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(32.7f, -1.38f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal16")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(8.38f, -1.33f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal17")
        {
            Vector3 posicioncamara = new Vector3(21f, 13f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(22.49f, 9.01f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal18")
        {
            Vector3 posicioncamara = new Vector3(21, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(29.12f, -1.32f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal19")
        {
            Vector3 posicioncamara = new Vector3(41f, 13f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(34.45f, 8.85f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal20")
        {
            Vector3 posicioncamara = new Vector3(41f, 0f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(34.44f, 4.31f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal21")
        {
            Vector3 posicioncamara = new Vector3(21f, 13f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(29.37f, 14.68f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal22")
        {
            Vector3 posicioncamara = new Vector3(41f, 13f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(32.7f, 14.8f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal23")
        {
            Vector3 posicioncamara = new Vector3(41f, 13f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(32.7f, 14.8f, 0);
            this.transform.position = posicionPlayer;
        }


    }

}
