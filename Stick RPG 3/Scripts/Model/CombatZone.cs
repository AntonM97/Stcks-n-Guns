using System;
namespace Scripts.Model;
using Scripts.Services;

public abstract class CombatZone: Building
{
    public string name { get; set; }



    public override void enterBuilding() {
        if (CurrentUserManager.currentUser == null){
            return;
        }
        if (CurrentUserManager.currentUser.UnlockedZones.Contains(name)){
            //Unity crafters, this is where you shine! Do your plane transitions here into the combat zone

        }


    }

    public void chickenOut(){
        //Do we want any consequences for chickening out?
        leaveZone();
    }

    public void leaveZone(){}


}