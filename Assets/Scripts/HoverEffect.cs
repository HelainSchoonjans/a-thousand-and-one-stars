using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    public float hoverAmount;

    private void OnMouseEnter()
    {
        Debug.Log("Hover effect triggered");
        transform.localScale += Vector3.one * hoverAmount;
    }

    private void OnMouseExit()
    {
        transform.localScale -= Vector3.one * hoverAmount;
    }

}
