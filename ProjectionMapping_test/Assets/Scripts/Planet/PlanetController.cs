using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlanetController : MonoBehaviour
{
    [SerializeField]
    private Transform tr;
    [SerializeField]
    private GameObject dosei;
    [SerializeField]
    private GameObject breakScreen;
    [SerializeField]
    private GameObject spaceBg;
    [SerializeField]
    private GameObject whiteBack;
    [SerializeField]
    private Sprite ball;
    [SerializeField]
    private GameObject hitMan;

    float time = 0;
    void Start()
    {
        
        
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time > 0)
        {
            if(!hitMan.activeSelf)
                hitMan.transform.DOMove(new Vector3(7.2f, 0.5f, 0), 10f).SetEase(Ease.OutQuad);
            hitMan.SetActive(true);
        }
        if(time > 180f)
        {
            
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ball;
            this.gameObject.transform.localScale = new Vector3(0.3f,0.3f, 1);
            var sequence = DOTween.Sequence();
            sequence.Append(tr.DOLocalPath(
            new[]
            {
                new Vector3(-1.5f, 4f, 0f),
                new Vector3(-4.5f, 2f, 0f)
            },
            3f, PathType.CatmullRom).SetEase(Ease.InExpo));
            sequence.Join(tr.DOScale(Vector3.one, 3f).SetEase(Ease.InExpo).OnComplete(dispBreakScreen));
            
            time = 0;
        }
    }

    private void dispBreakScreen()
    {
        
        tr.DOKill();
        //this.gameObject.SetActive(false);
        dosei.SetActive(false);
        breakScreen.SetActive(true);
        //whiteBack.SetActive(true);
        //spaceBg.SetActive(false);
        spaceBg.GetComponent<SpriteRenderer>().color = new Color(1,1,1,0.8f);
    }



}
