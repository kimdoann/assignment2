using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWinCondition : MonoBehaviour
{
    // The win position
    public Transform winPoint;

    // How close the player needs to be considered "win"
    public float winDistance = 1.0f;

    // The player position
    public Transform player;

    void Update()
    {
        // Calculate distance between player and win point
        float distanceToWin = Vector3.Distance(player.position, winPoint.position);

        // Check if player is within winDistance
        if (distanceToWin <= winDistance)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You Win!");
    }
}