using UnityEngine;

public class EventoCama : MonoBehaviour
{

    [SerializeField]
    private GameObject acumulador;
    public void LanzarCrearManta()
    {
       // Debug.Log("Voy a crear una manta");
       acumulador.gameObject.GetComponent<EventosClase>().CrearManta();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
