using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyObject : MonoBehaviour
{
    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();

        Color color = Color.blue;

        mesh.material.color = color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
