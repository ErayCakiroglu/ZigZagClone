using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    GroundSpawnController groundSpawnController;
    Rigidbody rb;
    [SerializeField] float yEndValue;
    int groundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        CheckGroundVerticalPosition();   
    }

    void CheckGroundVerticalPosition()
    {
        if(transform.position.y <= yEndValue)
        {
            SetRigidbodyValues();

            groundDirection = Random.Range(0, 2);

            if(groundDirection == 0)
            {
                transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x - 1f, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z);
            }
            else
            {
                transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z + 1f);

            }

            groundSpawnController.lastGroundObject = gameObject;
        }
    }

    void SetRigidbodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
