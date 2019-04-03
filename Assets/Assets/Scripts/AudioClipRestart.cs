using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioClipRestart : MonoBehaviour {
    
    /// <summary>
    /// Sonido Restart
    /// </summary>
    public AudioClip restartLevel;
    AudioSource restartL;

    // Use this for initialization
    void Start () {
        restartL = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(restartLevel, transform.position);

            if (restartL.isPlaying == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
