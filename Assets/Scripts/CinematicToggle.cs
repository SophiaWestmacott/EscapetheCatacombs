using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicToggle : MonoBehaviour
{
    public CharacterController playerControl;
    public Camera cinematicCam;
    public Camera playerCam;
    public GameObject player;
    public BasicInteract bI;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bI = player.GetComponent<BasicInteract>();
    }

    public void ToggleCinemaMode()
    {
        cinematicCam.enabled = !cinematicCam.enabled;
        playerCam.enabled = !playerCam.enabled;
        playerControl.enabled = !playerControl.enabled;
        bI.enabled = !bI.enabled;
    }
}
