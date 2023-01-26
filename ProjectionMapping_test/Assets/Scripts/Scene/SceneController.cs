using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneController : BaseScene
{

    public static MappingSceneController MapSceneCtrl;
    public static DefaultSceneController defaultSceneCtrl;

    void Start()
    {
        MapSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<MappingSceneController>();
        defaultSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<DefaultSceneController>();

        
    }

    void Update()
    {
       
        switch(ScenePhase)
        {
            case BaseScene.Scene.ShowScene:

                
                break;
            case BaseScene.Scene.MappingScene:
                MapSceneCtrl.DoUpdate();
                break;
            
            

            case BaseScene.Scene.DefaultScene:
                //Debug.Log("d");
                if(!defaultSceneCtrl.IsCheck)
                    defaultSceneCtrl.CheckNextScene();
                break;

            default:
                break;
        }
    }
}
