using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneController : BaseScene
{

    public static ShowSceneController ShowSceneCtrl;
    public static MappingSceneController MapSceneCtrl;

    void Start()
    {
        ShowSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<ShowSceneController>();
        MapSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<MappingSceneController>();
    }

    void Update()
    {
        switch(ScenePhase)
        {
            case Scene.MappingScene:
                
                break;
            
            case Scene.ShowScene:
                break;

            case Scene.DefaultScene:
                break;

            default:
                break;
        }
    }
}
