using UnityEngine;
using System.Collections;

public class LineScript : MonoBehaviour
{

    public GameObject LineStartPoint; //Reference to the first GameObject, anchor
    public GameObject LineEndPoint; //Reference to the second GameObject, the "connected"
    private LineRenderer line; //Line Renderer 

    //Use this for initilization
    void Start()
    {
        // Find Line Renderer of this GameObject
        line = this.gameObject.GetComponent<LineRenderer>();

    }

        //Update is called once per frame
        void Update() 
    {
        //Check if the GameObjects are not null

            //Upddte position of the two vertex of the Line Renderer
            line.SetPosition(0, LineStartPoint.transform.position);
            line.SetPosition(1, LineEndPoint.transform.position);

    }

}

