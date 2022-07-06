using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterController characterController;

    public float Speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));

        characterController.Move(move * Time.deltaTime * Speed);
    }
}
