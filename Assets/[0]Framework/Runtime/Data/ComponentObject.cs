//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/13/2018


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public class ComponentObject : IComponent, IDisposable
	{
		public Transform transform;
		public GameObject obj;
		public int poolType = -1;

		internal Dictionary<int, Transform> cachedTransforms;

		public void Dispose()
		{
			transform = null;
			obj = null;
			cachedTransforms.Clear();
		}
	}

	public static class ExtensionComponentObject
	{
		public static ComponentObject ComponentObject(this int entity) { return Storage<ComponentObject>.Instance.components[entity]; }

		public static bool HasComponentObject(this int entity) { return Storage<ComponentObject>.Instance.HasComponent(entity); }
	}
}