using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraCargadaController : MonoBehaviour
{
    // Start is called before the first frame update
    private float cycleInterval=0.01f;

    private List<ChargedParticle> chargedParticles;

    public GameObject[] esferas= new GameObject[14];
    
    private int contador=0;

    void Start()
    {
        for(int i=0;i<15;i++){
            esferas[i].gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other){
        if (other.gameObject.CompareTag("Particula")){
            other.gameObject.SetActive(false);
            esferas[contador].gameObject.SetActive(true);
            MovingChargedParticle mcp = esferas[contador].GetComponent<MovingChargedParticle>();
            chargedParticles = new List<ChargedParticle> (FindObjectsOfType<ChargedParticle>());
            StartCoroutine(Cycle(mcp));
            contador++;
        }else{
            //el objeto no es recolectable
        }
    }

    public IEnumerator Cycle(MovingChargedParticle mcp){
        bool isFirts= true;
        while(true){
            if(isFirts){
                isFirts=false;
                yield return new WaitForSeconds(Random.Range (0,cycleInterval));
            }
            ApplyMagneticForce(mcp);
            yield return new WaitForSeconds(cycleInterval);
        }
    }

    private void ApplyMagneticForce(MovingChargedParticle mcp){
        Vector3 newForce = Vector3.zero;

        foreach(ChargedParticle cp in chargedParticles){
            if (mcp==cp)
                continue;

            float distance= Vector3.Distance(mcp.transform.position,cp.gameObject.transform.position);
            float force=1000*mcp.charge*cp.charge/Mathf.Pow (distance,2);
            Vector3 direction = mcp.transform.position-cp.transform.position;
            direction.Normalize();

            newForce+=force*direction*cycleInterval;

            if (float.IsNaN(newForce.x))
                newForce=Vector3.zero;

            mcp.rb.AddForce(newForce);
        }
    }
}
