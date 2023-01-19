using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneController : BaseScene
{

    public static ShowSceneController ShowSceneCtrl;
    public static MappingSceneController MapSceneCtrl;
    public static DefaultSceneController defaultSceneCtrl;

    void Start()
    {
        ShowSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<ShowSceneController>();
        MapSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<MappingSceneController>();
        defaultSceneCtrl = GameObject.FindWithTag("SceneManager").GetComponent<DefaultSceneController>();
        
    }

    void Update()
    {
       
        switch(ScenePhase)
        {
            case BaseScene.Scene.ShowScene:

                ShowSceneCtrl.DoUpdate();
                break;
            case BaseScene.Scene.MappingScene:
                
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
