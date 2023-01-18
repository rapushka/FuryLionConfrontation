using JetBrains.Annotations;
using UnityEngine;

namespace Confrontation
{
	public class Cell : MonoBehaviour
	{
		[field: SerializeField] public Coordinates Coordinates { get; set; }
		[field: SerializeField] public Player     Owner       { get; private set; }
		[field: SerializeField] public Building   Building    { get; private set; }

		public bool IsNeutral => Owner is null;

		public bool IsEmpty => Building is null;
	}
}