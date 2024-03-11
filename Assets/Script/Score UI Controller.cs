using System.Collections;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private bool isHold;

    private void Start()
    {
        isHold = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return null; // Use null instead of WaitForEndOfFrame for improved performance.
            timeHold += Time.deltaTime;
        }

        Rigidbody bolaRigidbody = collider.GetComponent<Rigidbody>();
        if (bolaRigidbody != null)
        {
            bolaRigidbody.AddForce(transform.forward * force);
        }

        isHold = false;
    }
}