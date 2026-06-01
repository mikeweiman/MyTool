using UnityEditor;
using UnityEngine;

namespace MyTool.Editor
{
    public class MyToolEditorWindow : EditorWindow
    {
        [MenuItem("Tools/My Tool")]
        public static void OpenWindow()
        {
            GetWindow<MyToolEditorWindow>("My Tool");
        }

        private void OnGUI()
        {
            GUILayout.Label("My Tool", EditorStyles.boldLabel);

            if (GUILayout.Button("Say Hello"))
            {
                MyTool.SayHello();
            }
        }
    }
}
