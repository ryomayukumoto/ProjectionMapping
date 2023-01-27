using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalParticlemanager : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem petal;
   
    
    [SerializeField]
    private float amount;
    [SerializeField]
    private float speed;

    void Start()
    {
        petal = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if(Input.GetKeyDown("return"))
        {
            var emission = petal.emission;
            var main = petal.main;
            emission.rateOverTime = amount;
            main.simulationSpeed = speed;
            //amount *= 1.5f;


        }
    }

}

