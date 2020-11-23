using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargetBlock : MonoBehaviour
{
    public LayerMask hitLayers;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Pregunto si el jugador ha hecho click izquierdo
        {
            Vector3 mouse = Input.mousePosition; //Obtengo la posición del puntero/mouse
            Ray castPoint = Camera.main.ScreenPointToRay(mouse); //Lanzo un rayo a donde apunta el puntero
            RaycastHit hit; //Aquí se va a guardar la posición donde el rayo ha golpeado

            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers)) //Si el raycast no golpea un obstaculo
            {
                this.transform.position = hit.point + new Vector3(0,0.5f,0); //Muevo el target a la posición del puntero
            }
        }
    }
}
