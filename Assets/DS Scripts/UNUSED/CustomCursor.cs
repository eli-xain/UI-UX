using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D myCursorDesign;
    public Vector2 hotspot = new Vector2(49, 49);

    void OnMouseEnter()
    {
        Cursor.SetCursor(myCursorDesign, hotspot, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}