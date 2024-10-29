using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField] private FirstPersonController fpsController;
    [SerializeField] private Transform holdOBJ_Transform;

    private bool isHoldingItem = false;
    private Grabbable hintedOBJ = null;

    public bool IsHoldingItem => isHoldingItem;
    public Grabbable HintedOBJ => hintedOBJ;

    private void Update()
    {
        if (hintedOBJ != null)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                isHoldingItem = true;
                hintedOBJ.transform.parent = holdOBJ_Transform;
                hintedOBJ.transform.position = holdOBJ_Transform.position;
                hintedOBJ.transform.rotation = holdOBJ_Transform.rotation;
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                isHoldingItem = false;
                hintedOBJ.transform.parent = null;
                hintedOBJ = null;
            }
        }
    }

    public void SetHintedOBJ(Grabbable obj)
    {
        hintedOBJ = obj;
    }
}
