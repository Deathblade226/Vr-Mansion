﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FPC_InteractObject : MonoBehaviour
{

    [System.Serializable]
    public class InteractionEvent : UnityEvent { }

    public InteractionEvent onInteraction = new InteractionEvent();

    public void Interact()
    {
        onInteraction.Invoke();
    }
}
