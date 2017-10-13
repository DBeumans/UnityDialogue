using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData data)
    {
        CursorViewState.SetCursorTexture(CursorViewState.Get_Hover);
    }
    public void OnPointerExit(PointerEventData data)
    {
        CursorViewState.SetCursorTexture(CursorViewState.Get_Normal);
    }
}
