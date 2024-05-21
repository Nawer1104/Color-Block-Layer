using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Block : MonoBehaviour
{
    public List<Slide> slides = new List<Slide>();

    public bool isCompleted;

    private void Awake()
    {
        isCompleted = false;
    }

    private void OnMouseDown()
    {
        StartCoroutine(SlidesGo());

        GetComponent<PolygonCollider2D>().enabled = false;

        transform.DOScale(0, 1f).OnComplete(() => {
            isCompleted = true;

            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].CheckBlocks();
        });
    }

    IEnumerator SlidesGo()
    {
        for(int i = 0; i < slides.Count; i++)
        {
            slides[i].MoveToTarget();

            yield return new WaitForSeconds(0.25f);
        }
    }
}
