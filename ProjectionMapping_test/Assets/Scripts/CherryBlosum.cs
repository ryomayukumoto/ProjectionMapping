using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryBlosum : MonoBehaviour
{
    [Header("パーティクルのPrefab"), SerializeField]
    private ParticleSystem chery;

    private float time = 0;

    void Start(){}
    void Update()
    {
        time += Time.deltaTime;

        if(time > 30)
        {
            Instantiate(chery, new Vector3( 0, -5, 0), Quaternion.identity);
            time = 0;
        }
    }
}
