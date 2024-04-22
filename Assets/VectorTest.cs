using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public Transform atransform;
    public Transform btransform;
    public float distAtoB;

    private void OnDrawGizmos()
    {
        Vector2 a = atransform.position;
        Vector2 b = btransform.position;
        distAtoB = Vector2.Distance(a, b);
        //Vector2 pt = transform.position;
        //Vector2 dirToPT = pt.normalized;
        //Gizmos.DrawLine(Vector3.zero, dirToPT);
        Gizmos.DrawLine(a, b);
    }
}
