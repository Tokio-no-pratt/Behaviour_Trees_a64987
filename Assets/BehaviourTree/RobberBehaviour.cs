using UnityEditor.Toolbars;
using UnityEngine;

public class RobberBehaviour : MonoBehaviour
{

    BehaviourTree tree;


    void Start()
    {
        tree = new BehaviourTree();
        Node steal = new Node("Steal Something");
        Node goToDiamond = new Node("Go To Diamond");
        Node goToVan = new Node("Go To Van");


        steal.AddChild(goToDiamond);
        steal.AddChild(goToVan);
        tree.AddChild(steal);


        // eat = new Node("Eat Something");
        //Node pizza = new Node("Go To Pizza Shop");
        //Node buy = new Node("Buy Pizza");


        //eat.AddChild(pizza);
        //eat.AddChild(buy);
        //

        tree.PrintTree();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
