using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger : MonoBehaviour
{

    
    public GameObject uiObject;
    private void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
    }
}
