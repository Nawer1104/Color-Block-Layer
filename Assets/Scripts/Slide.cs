using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Slide : MonoBehaviour
{
    public Vector3 targetPos;

    public void MoveToTarget()
    {
        transform.DOMove(targetPos, 1f);
    }

    public bool Check()
    {
        if (Vector3.Distance(transform.position, targetPos) <= 0.1f)
        {
            return true;
        }
        else
            return false;
    }
}
