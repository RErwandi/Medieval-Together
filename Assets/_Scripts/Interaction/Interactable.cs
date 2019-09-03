﻿using Sirenix.OdinInspector;
using UnityEngine;

namespace Reynold.Interaction
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField] private Collider interactTrigger;
        
        void Start()
        {
        
        }
        
        void Update()
        {
        
        }

        [Button(ButtonSizes.Medium)]
        [EnableIf("@this.interactTrigger == null")]
        void CreateInteractTriggerOnChild()
        {
            var child = new GameObject();
            child.transform.SetParent(this.transform);
            child.transform.localPosition = Vector3.zero;
            child.transform.localScale = Vector3.one;;
            child.name = "Interact Trigger";
            var childCollider = child.AddComponent<SphereCollider>();
            childCollider.isTrigger = true;
            childCollider.radius = 1f;
            interactTrigger = childCollider;
        }
    }
}