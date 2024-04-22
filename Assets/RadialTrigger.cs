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

    private bool isInside = false;

    private void Update()
    {
        // Check if the enemy is inside the trigger area
        float distance = Vector2.Distance(transform.position, enemyTF.position);
        if (distance <= radius)
        {
            isInside = true;
        }
        else
        {
            isInside = false;
        }

        // Update the Gizmos color
        UpdateGizmoColor();
    }

    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Handles.color = isInside ? Color.red : Color.green;
        Handles.DrawWireDisc(origin, new Vector3(0, 0, 1), radius);
    }

    private void UpdateGizmoColor()
    {
#if UNITY_EDITOR
        SceneView.RepaintAll();
#endif
    }
}
