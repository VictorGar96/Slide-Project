using UnityEngine;
using System.Collections;

public class Mecanics : MonoBehaviour {
    #region Inicialización de terminos

    /// <summary>
    /// Vector Movimiento
    /// </summary>
    private Vector2 movimiento = Vector2.zero;

    /// <summary>
    /// Velocidad de Movimiento
    /// </summary>
    [SerializeField]
    public float speed = 15f;

    /// <summary>
    /// Rigidbody player
    /// </summary>
    public Rigidbody2D player;

    /// <summary>
    /// Posicion de objeto destruible
    /// </summary>
    private Vector2 collisionPos;

    /// <summary>
    /// Sonido Destruir objecto
    /// </summary>
    public AudioClip destroy;
    
    /// <summary>
    /// Sonido Comando Movimiento
    /// </summary>
    public AudioClip move;

    /// <summary>
    /// Sonido Colision
    /// </summary>
    public AudioClip colision;

    #endregion

    void Start () {

        player = GetComponent<Rigidbody2D>();
    }

    void Update() {

        Movimiento();
    }

    public void Movimiento() {

        if (movimiento.Equals(Vector2.zero))
        {
            Vector2 direccion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            
            if (!direccion.Equals(Vector2.zero))
            {
                movimiento = direccion;
                player.velocity = movimiento * speed ;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        movimiento =  Vector2.zero;
        player.velocity = Vector2.zero;
        AudioSource.PlayClipAtPoint(colision, transform.position);
       
        if (collision.gameObject.tag == "Destructible")
        {
            AudioSource.PlayClipAtPoint(destroy, transform.position);

            collisionPos = collision.transform.position;

            player.transform.position = collisionPos;

            Destroy(collision.gameObject);
                     
        }
          
    }
       
}
