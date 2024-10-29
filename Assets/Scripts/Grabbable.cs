using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Grabbable : MonoBehaviour
{
    private Material material;

    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        material.EnableKeyword("_EMISSION");
    }

    public void HintAsGrabbable()
    {
        material.SetColor("_EmissionColor", Color.cyan);
    }

    public void UnhintAsGrabbable()
    {
        material.SetColor("_EmissionColor", Color.black);
    }
}
