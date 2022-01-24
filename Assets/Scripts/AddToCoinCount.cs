using UnityEngine;
using UnityEngine.Events;

public class AddToCoinCount : MonoBehaviour
{
    public UnityEvent executeOnTriggerEnter;
    private void OnTriggerEnter(Collider other)
    {
        executeOnTriggerEnter.Invoke();
    }
}
