using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeManager : MonoBehaviour
{

    public TMP_Text coinText;
    private int Coin = 0;

    public AudioSource coinCollect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Coin++;
            coinText.text = "Change: $" + Coin.ToString();

            coinCollect.Play();
        }

    }
}
