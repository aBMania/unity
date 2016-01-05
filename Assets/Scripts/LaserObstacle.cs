﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (LineRenderer))]
public class LaserObstacle : Obstacle {

	LineRenderer lineRenderer;	

	public void Awake()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}

	public override void setColor(Color color){
		lineRenderer.material.color = color;
	}
}
