using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabitatInteraction : MonoBehaviour
{
    public float interactionDistance = 3f; // Distance within which the player can interact
    public KeyCode interactionKey = KeyCode.E; // Key to trigger interaction
    public GameObject interactionPrompt; // The UI prompt to display when interaction is possible

    private Transform player;

    void Start()
    {
        // Assuming the player is tagged as "Player", you can find it by tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // Initially hide the interaction prompt
        if (interactionPrompt != null)
        {
            interactionPrompt.SetActive(false);
        }
    }

    void Update()
    {
        // Check the distance between player and habitat
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // If the player is within interaction distance and the interaction key is pressed
        if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(interactionKey))
        {
            // Trigger the interaction method
            Interact();
        }

        // Show/hide interaction prompt based on distance
        if (distanceToPlayer <= interactionDistance)
        {
            if (interactionPrompt != null)
            {
                interactionPrompt.SetActive(true);
            }
        }
        else
        {
            if (interactionPrompt != null)
            {
                interactionPrompt.SetActive(false);
            }
        }
    }

    // Method to handle interaction with the habitat
    void Interact()
    {
        // Implement your interaction logic here
        Debug.Log("Interacting with the habitat!");
    }
}