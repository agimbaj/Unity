using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hallo");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("HalloWelt");
    }

    private void OnCollisonEnd(Collision collision)
    {

    }
}
