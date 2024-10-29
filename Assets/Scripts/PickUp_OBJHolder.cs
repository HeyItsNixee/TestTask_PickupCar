using UnityEngine;

public class PickUp_OBJHolder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerController.Instance.HintedOBJ == null || other.gameObject == null)
            return;

        var obj = other.GetComponent<Grabbable>();

        if (obj)
        {
            if (PlayerController.Instance.IsHoldingItem == false)
            {
                other.gameObject.transform.parent = transform;
            }
        }
    }
}
