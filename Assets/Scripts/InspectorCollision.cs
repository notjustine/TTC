using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InspectorCollision : MonoBehaviour
{

    public TMP_Text caughtText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            caughtText.text = "The Fare Inspector caught you!";
            Time.timeScale = 0;
        }
    }
}
