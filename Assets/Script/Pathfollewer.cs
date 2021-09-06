using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfollewer : MonoBehaviour
{
    Node[] PathNode;
    public GameObject Player;
    public float MoveSpeed;
    float Timer;
    int CurrentNode;
    static Vector3 CurrentPositionHolder;
    bool isbool;
    // Start is called before the first frame update
    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();
    }
    void CheckNode()
    {
        if (CurrentNode<PathNode.Length-1)
        {
            Timer = 0;
        }
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentNode);
        Timer += Time.deltaTime * MoveSpeed;

        if (Player.transform.position != CurrentPositionHolder)
        {
            Player.transform.position = Vector3.Lerp(Player.transform.position, CurrentPositionHolder, Timer);
        }
        else
        {
            if (CurrentNode==0)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (CurrentNode == 1)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0 );
            }
            else if (CurrentNode == 2)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, -90);
            }
            else if (CurrentNode == 3)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 180);
            }
            else if (CurrentNode == 4)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, -90);
            }
            else if (CurrentNode == 6)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (CurrentNode == 7)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (CurrentNode == 8)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 180);
            }
            else if (CurrentNode == 9)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (CurrentNode == 10)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (CurrentNode == 11)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, -90);
            }
            else if (CurrentNode == 12)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (CurrentNode == 13)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, -90);
            }
            else if (CurrentNode == 14)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (CurrentNode == 15)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (CurrentNode == 16)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (CurrentNode == 17)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 90);
            }
              else if (CurrentNode == 18)
            {
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            CurrentNode++;
                CheckNode();

          }

    }
}
