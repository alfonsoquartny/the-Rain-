using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    public AudioSource shot;
    public AudioSource reload;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        shot.Play();
    }

    public void Reload()
    {
        reload.Play();
    }
}
