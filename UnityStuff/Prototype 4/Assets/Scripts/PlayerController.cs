using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 6.0f;
    public bool hasPowerUp;
    private float powerUpStrength = 10.0f;
    public GameObject powerupIndicator;
    public Quaternion intendedRotation = Quaternion.Euler(0,0,0);
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        powerupIndicator.transform.rotation = intendedRotation;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdownRoutine());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerUp);
            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
    IEnumerator PowerUpCountdownRoutine()
    {
        powerupIndicator.gameObject.SetActive(true);
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
