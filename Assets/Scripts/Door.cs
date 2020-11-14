using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] bool locked;

    public bool Locked { get => locked; set => locked = value; }

    public void Open()
    {

    }
}
