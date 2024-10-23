using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
    bool shift = false;
    public float moveSpeed = 5f;
    public float jumpForce = 20;
    public float gravity = -9.81f;
    public float gravityScale = 5;
    public float minimumHeight = -2.55f;
    public float distanceToCheck = 1f;
    public bool isGrounded;
    float velocity;

    private void Update() {
        // Obtém as entradas do teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula a direção de movimento
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);

        if (Input.GetKeyDown(KeyCode.LeftShift)) shift = true;
        else if(Input.GetKeyUp(KeyCode.LeftShift)) shift = false;
        // Move o jogador
        if (shift) transform.Translate(2*(moveDirection * moveSpeed * Time.deltaTime));
        else transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        
        velocity += gravity * gravityScale * Time.deltaTime;
        
        //Left and right check
        if (Physics2D.Raycast(transform.position, Vector2.right, distanceToCheck) && transform.Translate.right > 0) {
            transform.right = 0;
        }
        if (Physics2D.Raycast(transform.position, Vector2.left, distanceToCheck) && transform.Translate.right < 0) {
            transform.right = 0;
        }
        //Jump Check && GroundCheck
        if (Physics2D.Raycast(transform.position, Vector2.down, distanceToCheck) && velocity < 0) velocity = 0;
        if (Input.GetKeyDown(KeyCode.Space)) velocity = jumpForce;

        transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    }
    */
}
