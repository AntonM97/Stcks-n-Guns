using System;
namespace Scripts.Model;

public abstract class Building
{
    public string name { get; set; }


    //Every building type should have its own implementation on what happens on entrance
    public abstract void enterBuilding();

    public void leaveBuilding(){
        //no need for different implementations here, every building is exited the same way
    }

    
}