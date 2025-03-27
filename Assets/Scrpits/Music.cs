using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource doSound, reSound, miSound, faSound, solSound, laSound, siSound;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Start");
        doSound = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        reSound = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        miSound = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        faSound = GameObject.FindWithTag("Fa").GetComponent<AudioSource>();
        solSound = GameObject.FindWithTag("Sol").GetComponent<AudioSource>();
        laSound = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        siSound = GameObject.FindWithTag("Si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message:"Press A");
            doSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(message:"Press S");
            reSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message:"Press D");
            miSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(message:"Press F");
            faSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(message:"Press G");
            solSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log(message:"Press H");
            laSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(message:"Press J");
            siSound.Play();
        }
    }
}
