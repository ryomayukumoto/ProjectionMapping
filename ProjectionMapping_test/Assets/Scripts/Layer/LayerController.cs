using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : BaseLayer
{
    [SerializeField] public const int Layers = 17;
    public AudioClip sound;
    public float time;
    int r = 0;
    int count = 0;
    List<Vector3> FlowerPos = new List<Vector3>//生成座標一覧

        {

            new Vector3(-8.6f, 4.5f, 0),new Vector3(-8.6f, -4.5f, 0),
            new Vector3(8.6f, 4.6f, 0),new Vector3(8.6f, -4.8f, 0),
            new Vector3(-7f, 3.5f, 0),new Vector3(-7f, -3.5f, 0),
            new Vector3(6.5f, -4f, 0),new Vector3(6.7f, 3f, 0),
            new Vector3(-5.3f, 2.8f, 0),new Vector3(-5f, -3f, 0),
            new Vector3(4.5f, -3.4f, 0),new Vector3(4.5f, 2f, 0),
            new Vector3(-1.1f, 4f, 0),new Vector3(1.5f, 3.8f, 0),
            new Vector3(-2.4f, -4.3f, 0),new Vector3(1.4f, -4.8f, 0)

        };//プレゼントが生成される座標地点の一覧。

    void Start()
    {

        Random.InitState(System.DateTime.Now.Millisecond);
        
                LayerArr = new string[Layers]
        {
            "Layer/0",
            "Layer/1",
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
            "Layer/flower1",
            "Layer/flower2",
            "Layer/flower3",
            "Layer/flower4",

        };
    }
    /*
    public void Update()
    {

        time += Time.deltaTime;

    }
    */
    public void AddLayer(int counter)
    {
        if(counter < LayerArr.Length)
        {

            if (counter == 13)
            {        
               
                for(int i = 0 ;i <=16; i++)
                {    
                    if (count == 3) 
                    {
                        counter += 1;
                        count = 0;
                    }
                    count += 1;
                

                    Instantiate(Resources.Load(LayerArr[counter]), FlowerPos[i], Quaternion.identity);

                }


            }
            else
         Instantiate(Resources.Load(LayerArr[counter]), Vector3.zero, Quaternion.identity);

        }

        AudioSource.PlayClipAtPoint(sound, transform.position);
    }

   
}

