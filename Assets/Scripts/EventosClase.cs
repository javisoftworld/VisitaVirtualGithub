using UnityEngine;

public class EventosClase : MonoBehaviour
{

    [SerializeField]
    private GameObject manta;
    private GameObject mantaClon;
    [SerializeField]
    private GameObject puntoCreacionDeManta;

   



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void CrearManta()
    {
        mantaClon = (GameObject)Instantiate(manta, puntoCreacionDeManta.gameObject.transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.J))
        {
           GetComponent<AudioSource>().Play();
            AudioSource[] audios = GetComponents<AudioSource>();
            audios[0].Play();
        }
    }
}
