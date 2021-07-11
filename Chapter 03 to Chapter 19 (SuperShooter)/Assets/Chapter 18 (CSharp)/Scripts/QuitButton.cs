using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    Button button;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Quit);
    }

    void Quit()
    {
        print("Quitting");
        Application.Quit();
    }
}