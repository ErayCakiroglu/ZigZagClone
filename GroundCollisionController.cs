using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] GroundDataTransmitter groundDataTransmitter;
    void OnCollisionExit(Collision temas)
    {
        if(temas.gameObject.CompareTag("Player"))
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
}
