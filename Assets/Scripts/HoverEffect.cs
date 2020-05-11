using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    public float hoverAmount;

    private bool IsPointingOverUI()
    {
        return UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
    }

    private void OnMouseEnter()
    {
        if(IsPointingOverUI())
        {
            return;
        }
        transform.localScale += Vector3.one * hoverAmount;
    }

    private void OnMouseExit()
    {
        if (IsPointingOverUI())
        {
            return;
        }
        transform.localScale -= Vector3.one * hoverAmount;
    }

}
