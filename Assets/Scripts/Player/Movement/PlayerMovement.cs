using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 12f;
	Vector3 velocity;
	public float gravity = -9.1f;
	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;
	private bool isGrounded;
	public float jumpHeight = 3f;

	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); // Test if on ground
		if (isGrounded && velocity.y < 0) velocity.y = -2f; // Reset Y velocity when on ground

		// Set left-right/foward-back movement
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z; // Get/set move coords
		controller.Move(move * speed * Time.deltaTime); // Move player

		if (Input.GetButtonDown("Jump") && isGrounded) velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

		velocity.y += gravity * Time.deltaTime; // calculate gravity
		controller.Move(velocity * Time.deltaTime); // apply gravity
	}
}
