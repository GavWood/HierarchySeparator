using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HierarchySeparator))]
[InitializeOnLoad]
public class HierarchySeparatorEditor : Editor
{
    private static GUIStyle labelStyle;

    static HierarchySeparatorEditor()
    {
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyItemOnGUI;
    }

    private static void HierarchyItemOnGUI(int instanceID, Rect selectionRect)
    {
        GameObject obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

        if (obj != null && obj.GetComponent<HierarchySeparator>())
        {
            EditorGUI.DrawRect(selectionRect, Color.gray);

            if (labelStyle == null)
            {
                labelStyle = new GUIStyle(GUI.skin.label)
                {
                    alignment = TextAnchor.MiddleCenter,
                    fontStyle = FontStyle.Normal,
                    fontSize = 12,
                    normal = new GUIStyleState() { textColor = Color.white }
                };
            }

            // Use EditorGUI.LabelField to display the label and replace the original text
            EditorGUI.LabelField(selectionRect, "", obj.name, labelStyle);
        }
    }

    public override void OnInspectorGUI()
    {
        HierarchySeparator separator = target as HierarchySeparator;

        EditorGUI.BeginChangeCheck();
        string newLabel = EditorGUILayout.TextField("Separator Label", separator.gameObject.name);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(separator.gameObject, "Update Separator Label");
            separator.gameObject.name = newLabel;
        }
    }
}
