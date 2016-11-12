using UnityEngine;
using System.Collections;

namespace imGekko.ItemSystem
{
    public interface IISObject
    {

        //Name
        //Value - gold value
        //Icon
        //Burden?
        //Quality level
        //Description
        string ISName { get; set; }
        int ISValue { get; set; }
        Sprite ISIcon { get; set; }
        int ISBurden { get; set; }
        ISQuality ISQuality { get; set; }

        //These go to other item interfaces
        //Equip
        //QuestItem flag
        //Durabillity
        //TakeDamage
        //Prefabs


    }
}