using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = Vector2.zero;
        if (Keyboard.current.wKey.isPressed)
        {
            inputVector.y += 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            inputVector.y -= 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            inputVector.x -= 1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            inputVector.x += 1;
        }
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
