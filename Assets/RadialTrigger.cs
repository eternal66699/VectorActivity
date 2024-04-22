using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public Transform enemyTF;
    [Range(0f, 5f)]
    public float radius;

    private void OnDrawGizmos()
    {
        bool isInside = enemyTF;
        Vector2 origin = transform.position;
        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(origin, new Vector3 (0,0,1),radius);
    }
}
