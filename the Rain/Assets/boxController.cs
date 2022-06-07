using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{

    public Animator ammoAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ammoAnimator.SetBool("active", true);

    }
}
