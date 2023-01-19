using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScene : MonoBehaviour
{
    public static LayerController LayerCtrl;
    protected Scene scenePhase = Scene.DefaultScene;
    public Scene ScenePhase{get{return scenePhase;}set{scenePhase = value;}}
    public enum Scene
    {
        ShowScene,
        MappingScene,
        DefaultScene
    }

    protected void InitScene(string layerManager)
    {
        Instantiate(Resources.Load(layerManager), new Vector3(0f,0f,0f), Quaternion.identity);
        LayerCtrl = GameObject.Find(layerManager + "(Clone)").GetComponent<LayerController>();
    }
    protected void sceneReset(string tag)
    {
        ScenePhase &= 0;
        GameObject[] destroyObj = GameObject.FindGameObjectsWithTag(tag);
        for(int i = 0; i < destroyObj.Length; i++)
        {
            Destroy(destroyObj[i]);
        }
    }
    
}
