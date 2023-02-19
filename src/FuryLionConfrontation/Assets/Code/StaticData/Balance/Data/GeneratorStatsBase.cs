using System;
using UnityEngine;

namespace Confrontation
{
	[Serializable]
	public class GeneratorStatsBase : IGeneratorStats
	{
		[field: SerializeField] public float CoolDown { get; private set; }

		[field: SerializeField] public int Amount { get; private set; }
	}
}