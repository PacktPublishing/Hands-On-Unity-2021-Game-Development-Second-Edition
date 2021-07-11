using UnityEngine;

public class EnableCursor : MonoBehaviour
{
    void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

