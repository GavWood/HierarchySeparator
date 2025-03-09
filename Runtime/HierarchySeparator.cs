using UnityEngine;

[ExecuteInEditMode]
public class HierarchySeparator : MonoBehaviour
{
    [SerializeField] private string separatorLabel = "Separator";

    private void Reset()
    {
        gameObject.name = separatorLabel;
    }

    private void OnValidate()
    {
        // Make the GameObject inactive
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }

        // Set the position
        if (transform.position != Vector3.zero)
        {
            transform.position = Vector3.zero;
        }

        // Reset rotation to identity
        if (transform.rotation != Quaternion.identity)
        {
            transform.rotation = Quaternion.identity;
        }

        // Set the tag to EditorOnly
        if (gameObject.tag != "EditorOnly")
        {
            gameObject.tag = "EditorOnly";
        }
    }
}

