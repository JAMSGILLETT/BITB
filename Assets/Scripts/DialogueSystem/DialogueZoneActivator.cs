using UnityEngine;

public class DialogueZoneActivator : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueObject dialogueObject;

    public void UpdateDialogueObject(DialogueObject dialogueObject)
    {
        this.dialogueObject = dialogueObject;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Movement movement))
        {
            movement.Interactable?.Interact(movement);
        }
    }

    public void Interact(Movement movement)
    {
        foreach (DialogueResponseEvents responseEvents in GetComponents<DialogueResponseEvents>())
        {
            if (responseEvents.DialogueObject == dialogueObject)
            {
                movement.DialogueUI.AddResponseEvents(responseEvents.Events);
                break;
            }
        }

        movement.DialogueUI.ShowDialogue(dialogueObject);
    }
}

