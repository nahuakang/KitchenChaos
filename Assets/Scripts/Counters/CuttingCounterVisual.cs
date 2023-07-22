using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounterVisual : MonoBehaviour
{
    [SerializeField] private CuttingCounter cuttingCounter;

    private const string CUT = "Cut";

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        cuttingCounter.OnCut += ContainerCounterOnOnCut;
    }

    private void ContainerCounterOnOnCut(object sender, EventArgs e)
    {
        animator.SetTrigger(CUT);
    }
}
