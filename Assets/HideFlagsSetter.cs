using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class HideFlagsSetter : MonoBehaviour 
{
	public HideFlags flags;

	public HideFlags currentFlags;

	// Use this for initialization
	[ContextMenu("Set Flags")]
	void Set () 
	{
		this.gameObject.hideFlags = flags;
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentFlags = this.gameObject.hideFlags;
	}
}
