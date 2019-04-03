using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioClipNext : MonoBehaviour {
    
    /// <summary>
    /// Sonido Siguiente nivel;
    /// </summary>
    public AudioClip next;
    AudioSource n;
    
    void Start () {
        n = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(next, transform.position);

            if (n.isPlaying == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

    }
    
}
