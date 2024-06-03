﻿/*
work by adamman
*/
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace AdammanWorkSpace
{
    //Blend Color Tool  /////////////////////////////////////////////////
    [AddComponentMenu("UI/Adamman/Blend Color"), RequireComponent(typeof(Graphic))]
    public class BlendColor : BaseMeshEffect
    {
        // BlendMode /////////////////////////////////////////////////
        public enum BlendMode
        {
            Multiply,
            Additive,
            Subtractive,
            Override,
        }

        [SerializeField]
        private BlendMode m_blendMode = BlendMode.Multiply; // Default to Multiply
        [SerializeField]
        private Color m_color = Color.white; // Default to white

        //  Properties  /////////////////////////////////////////////////
        public BlendMode blendMode { get { return m_blendMode; } set { if (m_blendMode != value) { m_blendMode = value; Refresh(); } } }
        // Properties  /////////////////////////////////////////////////
        public Color color { get { return m_color; } set { if (m_color != value) { m_color = value; Refresh(); } } }

        // Refresh  /////////////////////////////////////////////////
        public override void ModifyMesh(VertexHelper vh)
        {
            if (IsActive() == false)
            {
                return;
            }

            List<UIVertex> vList = ListPoolEffect<UIVertex>.Get();

            vh.GetUIVertexStream(vList);

            ModifyVertices(vList);

            vh.Clear();
            vh.AddUIVertexTriangleStream(vList);

            ListPoolEffect<UIVertex>.Release(vList);
        }

        // ModifyVertices  /////////////////////////////////////////////////
        private void ModifyVertices(List<UIVertex> vList)
        {
            if (IsActive() == false || vList == null || vList.Count == 0)
            {
                return;
            }

            UIVertex newVertex;
            for (int i = 0; i < vList.Count; i++)
            {
                newVertex = vList[i];
                byte orgAlpha = newVertex.color.a;
                switch (m_blendMode)
                {
                    case BlendMode.Multiply:
                        newVertex.color *= m_color;
                        break;
                    case BlendMode.Additive:
                        newVertex.color += m_color;
                        break;
                    case BlendMode.Subtractive:
                        newVertex.color -= m_color;
                        break;
                    case BlendMode.Override:
                        newVertex.color = m_color;
                        break;
                    default:
                        break;
                }
                newVertex.color.a = orgAlpha;
                vList[i] = newVertex;
            }
        }

        // to refresh  /////////////////////////////////////////////////
        private void Refresh()
        {
            if (graphic != null)
            {
                graphic.SetVerticesDirty();
            }
        }
    }
}
