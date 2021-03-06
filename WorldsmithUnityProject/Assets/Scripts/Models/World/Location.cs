﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Location : WorldElement
{
    
    public enum LocationType {  Settled, Productive, Defensive, Cultural, Natural}
    public enum LocationSubType {  Unassigned, City, Town,  Village, Homestead, Dwelling, Mine, Outpost, Sanctuary, Hazard }
    
    // EcoBlock variables
    public Ruler localRuler;
    public Ruler dominatingRuler;
    public List<Ruler> secondaryRulers = new List<Ruler>();

    // Column Variables
    protected LocationType locType;
    protected LocationSubType locSubType;
    public string[] dominateStrings;    
    public int culturalType;
    public int politicalType;
    public int economicType;

 
    public Location()
    {

    }
    public Location(LocationType type, LocationSubType subtype, string name)
    {
        elementType = ElementType.Location;
        locType = type;
        elementID = name;
        locSubType = subtype;    
    }

    public void SetLocationType (LocationType type)
    {
        locType = type;
    }
    public void SetLocationSubType(LocationSubType type)
    {
        locSubType = type;
    }
    public LocationType GetLocationType()
    {
        return locType;
    }

    public LocationSubType GetLocationSubType()
    {
        return locSubType;
    }

    public virtual void SetSpecialProperties()
    {

    }
}
