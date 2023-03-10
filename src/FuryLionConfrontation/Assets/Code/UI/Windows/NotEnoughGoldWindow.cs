using UnityEngine;
using Zenject;

namespace Confrontation
{
	public class NotEnoughGoldWindow : WindowBase
	{
		public override WindowBase Accept(IWindowVisitor windowVisitor) => windowVisitor.Visit(this);
		
		public new class Factory : PlaceholderFactory<Object, NotEnoughGoldWindow> { }
	}
}