using UnityEngine;

public class CierraScript : MonoBehaviour
{
    public float rotationSpeed = 150f; // Velocidad de rotación de la sierra

    void Update()
    {
        // Rotar la sierra alrededor de su propio eje hacia la derecha
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Obtener el componente Movement del jugador y llamar a ResetPlayer
            Movement playerMovement = other.GetComponent<Movement>();
            if (playerMovement != null)
            {
                playerMovement.ResetPlayer();
            }
        }
    }
}
