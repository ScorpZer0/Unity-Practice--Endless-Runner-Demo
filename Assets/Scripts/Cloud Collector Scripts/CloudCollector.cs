using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cloud" || other.tag == "KillerCloud")
        {
            other.gameObject.SetActive(false);
        }
    }
}
