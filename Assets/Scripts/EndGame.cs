using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{

    public TMP_Text endText;

    public AudioSource winSong;
    public AudioSource mainSong;
    public AudioSource ambience;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winSong.Play();

            mainSong.Stop();
            ambience.Stop();

            endText.text = "You escaped the Fare Inspector!";
            Time.timeScale = 0;
        }
    }
}
