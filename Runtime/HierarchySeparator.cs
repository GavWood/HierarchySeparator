using UnityEngine;

[ExecuteInEditMode]
public class HierarchySeparator : MonoBehaviour
{
    [SerializeField] private string separatorLabel = "Separator";

    private void Reset()
    {
        gameObject.name = separatorLabel;
    }

    private void OnEnable()
    {
        if (Application.isPlaying)
        {
            gameObject.SetActive(false);
        }
    }
}

