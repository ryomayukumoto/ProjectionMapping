using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField]
    private Material[] materials;
    [SerializeField]
    private ParticleSystem particle;

    private float time = 0; 

    void Update()
    {
        time += Time.deltaTime;
        if(time > 5f)
        {
            particle.GetComponent<ParticleSystemRenderer>().material = materials[Random.Range(0,4)];
            Instantiate(particle);
            time = 0;
        }
    }
}
