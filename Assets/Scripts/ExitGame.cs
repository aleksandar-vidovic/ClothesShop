using UnityEngine;

public class ExitGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            Application.Quit();
    }
}
