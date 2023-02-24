using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDetector : MonoBehaviour
{
    [SerializeField] private Transform RespawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = RespawnPoint.position;
        }
    }
}
