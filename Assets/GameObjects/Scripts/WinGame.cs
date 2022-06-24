using UnityEngine;

public class WinGame : MonoBehaviour
{

    public GameManagement management;

    private void OnTriggerEnter(Collider other)
    {
        management.GameComplete();
    }
}
