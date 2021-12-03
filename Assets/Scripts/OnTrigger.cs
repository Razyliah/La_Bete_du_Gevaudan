using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "PlayerCapsule")
        {
            print("trigger enter zone");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "PlayerCapsule")
        {
            print("trigger exit zone");
        }
    }

    private void OnTriggerStay(Collider col)
    {
        print("trigger stay on zone");
    }
}
