using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingDamageControl : MonoBehaviour {

    private static FloatingDamageText popupText;
    public static GameObject canvas;

    public static void Initialize()
    {
        canvas = GameObject.Find("HubGUI");
        if (!popupText)
                     popupText = Resources.Load<FloatingDamageText>("Prefabs/DTextParent");
    }

    public static void CreateFloatingText(string text, Transform location)
    {
        FloatingDamageText instance = Instantiate(popupText);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(new Vector2(location.position.x + Random.Range(0f, 2.5f),location.position.y + Random.Range(1f, 1.5f)));

        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = screenPosition;
        instance.SetText(text);
    }

}
