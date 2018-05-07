using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeSprite : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    public Sprite Mars;
    public Sprite Earth;
    public Sprite Sun;
    public Sprite Jupiter;
    public Sprite Neptune;
    public Sprite Planet_X;
    public Sprite Pluto;
    public Sprite Uranus;

    Sprite[] sprites = new Sprite[20];
    int i;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        sprites[0] = Mars;
        sprites[1] = Earth;
        sprites[2] = Sun;
        sprites[3] = Jupiter;
        sprites[4] = Neptune;
        sprites[5] = Planet_X;
        sprites[6] = Pluto;
        sprites[7] = Uranus;

        i = 0;

    }

    bool Conditions()
    {


        return true;
    }

    public void Change()
    {
       
            spriteRenderer.sprite = sprites[i++];
            if (i == 7) i = 0;
        
       
    }
}
