using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CatController : MonoBehaviour
{

    void Update()
    {
        

       // move();
        // 向き決める => 移動 => 壁に当たる => 向き決める...

        // 画面外にいかない
        // 反射実装
    }
    void Start()
    {
        transform.DOLocalPath(
        new[]
        {
            new Vector3(2f, -2f, 0f),
            new Vector3(7f, 3.5f, 0f),
            new Vector3(-2, 2f, 0),
        },
        20f, PathType.CatmullRom).SetEase(Ease.Linear).SetOptions(true).SetLoops(-1, LoopType.Restart);

        transform.DOScale(new Vector3(0.5f, 0.5f, 1),10).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

        


    /// <summary>
    /// 画面内にいるか判定する関数
    /// </summary>
    /// <param name="pos">対象オブジェクトの座標</param>
    /// <returns>画面内(true), 画面外(false)</returns>
    private bool checkInScreen(Vector3 pos)
    {
        if(!(pos.x < 8 || pos.x > -8) && (pos.y > -4.5 || pos.y < 4.5))
            return false;
        
        return true;
    }
}
