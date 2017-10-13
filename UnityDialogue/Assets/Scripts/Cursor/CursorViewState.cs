using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorViewState : MonoBehaviour {
    
    private static Texture2D hover;
    public static Texture2D Get_Hover { get { return hover; } }
    
    private static Texture2D normal;
    public static Texture2D Get_Normal { get { return normal; } }

    private void Start()
    {
        loadTextures();

        SetCursorTexture(normal);
    }

    private void loadTextures()
    {
        hover = (Texture2D)Resources.Load("Cursors/link");
        normal = (Texture2D)Resources.Load("Cursors/normal");
    }

    public static void SetCursorTexture(Texture2D texture)
    {
        Cursor.SetCursor(texture, Vector2.zero, CursorMode.Auto);
    }

}
