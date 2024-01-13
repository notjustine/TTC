using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Adult"))
        {
            Destroy(collision.gameObject);
        }
    }
}
