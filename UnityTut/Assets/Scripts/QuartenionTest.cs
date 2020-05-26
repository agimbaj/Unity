using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuartenionTest : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.Euler(40, 40, 40);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = target.position - transform.position;

        transform.rotation = Quaternion.LookRotation(vector3);
    }
}
