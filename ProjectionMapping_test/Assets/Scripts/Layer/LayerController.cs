
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : BaseLayer
{
    [SerializeField] public const int Layers = 12;
    public AudioClip sound;
    void Start()
    {

        Random.InitState(System.DateTime.Now.Millisecond);

        LayerArr = new string[Layers]
{
            "Layer/2",
            "Layer/3",
            "Layer/4",
            "Layer/5",
            "Layer/6",
            "Layer/7",
            "Layer/8",
            "Layer/9",
            "Layer/10",
            "Layer/11",
            "Layer/12",
            "Layer/13",

};
    }
    public void AddLayer(int counter)
    {
        if (counter < LayerArr.Length)
        {

            if (counter == 11)
            {
                Instantiate(Resources.Load(LayerArr[counter]), new Vector3(0, 0, -1), Quaternion.identity,transform);
            }
            else
                Instantiate(Resources.Load(LayerArr[counter]), Vector3.zero, Quaternion.identity, transform);

        }

        AudioSource.PlayClipAtPoint(sound, transform.position);
    }


}