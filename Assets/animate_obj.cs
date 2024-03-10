using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate_obj : MonoBehaviour
{
    public float moveDistance = 4.0f;
    public float moveSpeed = 2.0f;
    public float pauseDuration = 5.0f;

    void Start()
    {
        StartCoroutine(RunSequentially());

    }

    IEnumerator hor_AnimationLoop()
    {
        for (int i = 0; i < 5; i++)
        {
            
            yield return new WaitForSeconds(pauseDuration);

            LeanTween.moveLocalX(gameObject,moveDistance, moveSpeed);

            yield return new WaitForSeconds(pauseDuration);

            LeanTween.moveLocalX(gameObject, -moveDistance, moveSpeed);
        }
        LeanTween.moveLocalX(gameObject, 0, moveSpeed);
    }

    IEnumerator diag_AnimationLoop_1()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(pauseDuration);

            LeanTween.moveLocalX(gameObject, moveDistance, moveSpeed);
            LeanTween.moveLocalY(gameObject, 4, moveSpeed);

            yield return new WaitForSeconds(pauseDuration);


            LeanTween.moveLocalX(gameObject, -moveDistance, moveSpeed);
            LeanTween.moveLocalY(gameObject, 0, moveSpeed);
        }
        LeanTween.moveLocalX(gameObject, 0, moveSpeed);
        LeanTween.moveLocalY(gameObject, 2, moveSpeed);
    }

    IEnumerator diag_AnimationLoop_2()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(pauseDuration);

            LeanTween.moveLocalX(gameObject, moveDistance, moveSpeed);
            LeanTween.moveLocalY(gameObject, 0, moveSpeed);

            yield return new WaitForSeconds(pauseDuration);


            LeanTween.moveLocalX(gameObject, -moveDistance, moveSpeed);
            LeanTween.moveLocalY(gameObject, 4, moveSpeed);
        }
        LeanTween.moveLocalX(gameObject, 0, moveSpeed);
        LeanTween.moveLocalY(gameObject, 2, moveSpeed);
    }

    IEnumerator vert_AnimationLoop()
    {
        for (int i=0;i<5;i++)
        {
            yield return new WaitForSeconds(pauseDuration);

            LeanTween.moveLocalY(gameObject, 4, moveSpeed);

            yield return new WaitForSeconds(pauseDuration);

            LeanTween.moveLocalY(gameObject, 0, moveSpeed);
        }
        LeanTween.moveLocalY(gameObject,2, moveSpeed);
    }
    IEnumerator RunSequentially()
    {
        yield return StartCoroutine(hor_AnimationLoop());
        yield return StartCoroutine(vert_AnimationLoop());
        
        yield return StartCoroutine(diag_AnimationLoop_1());
        yield return StartCoroutine(diag_AnimationLoop_2());

    }




}
