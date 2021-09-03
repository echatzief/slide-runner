using UnityEngine.UI;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    // Start is called before the first frame update

    private Text lifes;
    private float HUDRefreshRate = 1f;
    private float timer;

    void Start()
    {
       lifes.text = "10";
    }

    // Update is called once per frame
    void Update()
    {
    }
}
