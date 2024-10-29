using UnityEngine;

public class Garage : MonoBehaviour
{
    [SerializeField] private Animator garageAnimator;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerController.Instance.gameObject)
            garageAnimator.SetBool("IsOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == PlayerController.Instance.gameObject)
            garageAnimator.SetBool("IsOpen", false);
    }
}
