using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : IHeapItem<Node>
{
    public int gridX; //Posición X en la cadena de nodos
    public int gridY; //Posición Y en la cadena de nodos

    public bool walkable; //Comprueba si el nodo está siendo obstaculizado
    public Vector3 worldPos; //La posición en el mundo del nodo

    public Node Parent; //Aqui se va a guardar el nodo del que se viene para que traze el camino más corto

    public int gCost; //El coste para moverse al siguiente cuadrado
    public int hCost; //La distancia hasta el nodo final desde este nodo

    public int FCost { get { return gCost + hCost; } } //Definimos FCost como la suma de gCost y hCost. No necesitamos el set ya que no vamos a modificar FCost

    int heapIndex;

    public Node(bool n_isWalkable, Vector3 n_pos, int n_gridX, int n_gridY) //Constructor 
    {
        walkable = n_isWalkable;
        worldPos = n_pos;
        gridX = n_gridX;
        gridY = n_gridY;
    }

    public int HeapIndex { get { return heapIndex; } set { heapIndex = value; } }

    public int CompareTo(Node nodeToCompare)
    {
        int compare = FCost.CompareTo(nodeToCompare.FCost);
        if(compare == 0)
        {
            compare = hCost.CompareTo(nodeToCompare.hCost);
        }
        return -compare;
    }
}
