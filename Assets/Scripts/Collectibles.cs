using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    public Sprite icon;
    public GameObject Obj;
    public Image image;
    

    public Vector2 position {
        get { return new Vector2(transform.position.x, transform.position.z); }
    }

    
}
