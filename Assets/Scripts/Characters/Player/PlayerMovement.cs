using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ICharacter character;
    private float walkSpeed, runSpeed;

    private void Awake()
    {
        character = GetComponent<ICharacter>();
        walkSpeed = character.MyAttributes.WalkSpeed;
        runSpeed = character.MyAttributes.RunSpeed;
    }

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (input != Vector2.zero)
        {
            bool running = Input.GetKey(KeyCode.LeftShift);
            Move(running ? runSpeed : walkSpeed, input);
        }
    }

    private void Move(float speed, Vector2 input)
    {
        Vector3 pos = transform.position;
        pos += Time.deltaTime * speed * (Vector3.right * input.x + Vector3.forward * input.y);
        transform.position = pos;
    }
}
