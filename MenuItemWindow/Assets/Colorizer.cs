
using UnityEditor;
using UnityEngine;

public class Colorizer : EditorWindow
{
    Color color;
    // Add menu named "My Window" to the Window menu
    [MenuItem("Colorizer/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<Colorizer>("Colorizer");
    }

    private void OnGUI()
    {

        color = EditorGUILayout.ColorField("Color", color);
        if (GUILayout.Button("Colorizer"))
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer)
                {
                    renderer.sharedMaterial.color = color;
                }
            }
        }
    }
}


