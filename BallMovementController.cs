using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] BallDataTransmitter ballDataTransmitter;
    [SerializeField] float ballMoveSpeed;

    void Update()
    {
        SetBallMovement();
    }

    void SetBallMovement()
    {
        transform.position += ballDataTransmitter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
