using UnityEditor;

namespace com.game.package
{
    public class EditorExample : EditorWindow
    {
        // Add menu named "My Window" to the Window menu
        [MenuItem("Game Package/My Window")]
        private static void Init()
        {
            // Get existing open window or if none, make a new one:
            EditorExample window = (EditorExample)GetWindow(typeof(EditorExample));
            window.Show();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}