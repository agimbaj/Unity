using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    private CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _characterController.Move(Movement());
    }

    Vector3 Movement()
    {
        Vector3 moveVector = Vector3.zero;

        moveVector += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime;
        moveVector += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime;

        moveVector *= speed;
        return moveVector;
    }
}
