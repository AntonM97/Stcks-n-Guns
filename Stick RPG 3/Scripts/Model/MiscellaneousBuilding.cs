using System;
namespace Scripts.Model;

public abstract class MiscellaneousBuilding : Building
{
    public string name { get; set; }

    public float OpeningTime {get; set;}
    public float ClosingTime {get; set;}




    public override void enterBuilding(){

    }

    
}