using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EleccionTortas : MonoBehaviour
{
    public Sprite[] TortasSprite;
    public Sprite[] TortaCircular;
    public int SpritePosition = 0;
    public int posicion = 0;
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetButton("botonder"))
        {
            SpritePosition++;
            if (SpritePosition <= TortasSprite.Length)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = TortasSprite[SpritePosition];
            }
            else if (SpritePosition > TortasSprite.Length - 1)
            {
                SpritePosition = 0;

            }




        }
        */
    }
    public void CambioTorta()
    {
       
        SpritePosition++;
        if (SpritePosition <= TortasSprite.Length-1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = TortasSprite[SpritePosition];
        }
        else if (SpritePosition > TortasSprite.Length -1)
        {
            SpritePosition = 0;

        }
    }
    public void TortaRedonda()
    {

        posicion++;
        if (posicion <= TortaCircular.Length - 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = TortaCircular[posicion];
        }
        else if (posicion > TortaCircular.Length - 1)
        {
            posicion = 0;

        }
    }
    public void CambioTortaNegativo()
    {

        SpritePosition--;
        if (SpritePosition >= TortaCircular.Length)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = TortasSprite[SpritePosition];
        }
        else if (SpritePosition < TortasSprite.Length)
        {
            SpritePosition = 12;

        }
    }
    public void TortaRedondaNegativo()
    {

        posicion--;
        if (posicion >= TortasSprite.Length)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = TortaCircular[posicion];
        }
        else if (posicion < TortaCircular.Length)
        {
            posicion = 11;

        }
    }
}
