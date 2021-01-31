using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
	//This thing can Invoke, basically trigger, different things you put in it.
	public UnityEvent TriggerEvent;

	private void OnTriggerEnter(Collider other)
	{
		TriggerEvent.Invoke();
	}
}
