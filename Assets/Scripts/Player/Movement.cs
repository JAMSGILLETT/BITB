using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;

    public float moveSpeed = 5f;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (dialogueUI.IsOpen)
        {
            animator.SetFloat("Speed", 0);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interactable?.Interact(this);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Interactable?.Interact(this);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Interactable?.Interact(this);
            }

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    }

    void FixedUpdate()
    {
        if (dialogueUI.IsOpen) return;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
