using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
       doorAnimator = GetComponent<Animator>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vacuum"))
        {
            if(doorAnimator != null)
            {
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}
