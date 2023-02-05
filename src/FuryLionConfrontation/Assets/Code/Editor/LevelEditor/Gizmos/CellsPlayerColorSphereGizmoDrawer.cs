using UnityEditor;
using UnityEngine;
using Zenject;

namespace Confrontation.Editor
{
	public class CellsPlayerColorSphereGizmoDrawer : IInitializable, IGuiRenderable
	{
		private static bool _drawGizmosColorOfOwner;

		public void Initialize() => _drawGizmosColorOfOwner = true;

		public void GuiRender()
			=> _drawGizmosColorOfOwner
				= EditorGUILayout.Toggle(nameof(_drawGizmosColorOfOwner).Pretty(), _drawGizmosColorOfOwner);

		[DrawGizmo(GizmoType.Selected | GizmoType.NonSelected)]
		private static void DrawGizmoForMyScript(Cell cell, GizmoType gizmoType)
		{
			if (_drawGizmosColorOfOwner == false)
			{
				return;
			}

			if (cell.RelatedRegion == true)
			{
				GizmoUtils.SetColorBy(cell.RelatedRegion.OwnerPlayerId);
			}

			Gizmos.DrawSphere(cell.transform.position, 0.25f);
		}
	}
}