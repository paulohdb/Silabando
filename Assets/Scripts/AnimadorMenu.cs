using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimadorMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> objetosParaAnimar;
    public float waitForSeconds = 0f, moveDistance = 5f;
    public LeanTweenType easeIn, easeOut;
    public float moveTime = 1f;
    private LTSeq seq;

    void Start()
    {

        seq = LeanTween.sequence();
        restartSequence();

    }

    void restartSequence()
    {
        //seq = LeanTween.sequence();

        if (seq is null)
            return;

        foreach (GameObject objeto in objetosParaAnimar)
        {
            seq.append(objeto.LeanMoveY(objeto.transform.position.y + moveDistance, moveTime).setEase(easeIn));
            seq.append(objeto.LeanMoveY(objeto.transform.position.y, moveTime).setEase(easeOut));
            seq.append(waitForSeconds);
        }
        seq.append(moveTime);
        seq.append(restartSequence);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
