using UnityEngine;

public class GrabTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Grabbable grabbaleOBJ = other.GetComponent<Grabbable>();

        if (grabbaleOBJ)
        {
            grabbaleOBJ.HintAsGrabbable();
            PlayerController.Instance.SetHintedOBJ(grabbaleOBJ);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Grabbable grabbaleOBJ = other.GetComponent<Grabbable>();

        if (grabbaleOBJ)
        {
            grabbaleOBJ.UnhintAsGrabbable();
        }
    }
}
