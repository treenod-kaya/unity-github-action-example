using UnityEditor;
using com.game.package;
using UnityEngine;

public class SampleEditor : EditorWindow
{
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/Sample Editor")]
    private static void Init()
    {
        SampleEditor window = (SampleEditor)GetWindow(typeof(SampleEditor));
        window.Show();

        var sum = EditorExample.Sum(1, 2);
        Debug.Log(sum);
    }
}
