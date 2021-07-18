using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneRestarter : MonoBehaviour
{
    public void Restarter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Restarter();
        }
        else
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
