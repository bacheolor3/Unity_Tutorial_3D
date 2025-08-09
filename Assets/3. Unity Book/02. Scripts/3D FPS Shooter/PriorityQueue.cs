﻿using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Assets._3._Unity_Book._02._Scripts._3D_FPS_Shooter
{
    public class PriorityQueue : MonoBehaviour
    {
        private List<Node> nodes = new List<Node>();

        public int Length
        {
            get { return nodes.Count; }
        }

        public bool Contains(Node node)
        {
            return nodes.Contains(node);
        }

        public Node First()
        {
            if (nodes.Count == 0)
            {
                return null;
            }
            return nodes[0];
        }

        public void Push(Node node)
        {
            nodes.Add(node);
            nodes.Sort();
        }

        public void Remove(Node node)
        {
            nodes.Remove(node);
            nodes.Sort();
        }
    }
}