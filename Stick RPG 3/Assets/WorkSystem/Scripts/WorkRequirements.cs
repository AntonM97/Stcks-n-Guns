using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WorkRequirements", menuName = "DataAssets/Works/WorkRequirements")]
public class WorkRequirements : ScriptableObject
{
    public enum StatRequired { intelligence, strength, charisma }
    [SerializeField] private string workName;
    [SerializeField] private StatRequired statRequired;
    [SerializeField] private int statValueRequired;

    public string getWorkName()
    {
        return workName;
    }

    public int getStatWalueRequired()
    {
        return statValueRequired;
    }
}


