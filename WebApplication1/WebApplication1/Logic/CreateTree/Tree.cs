using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Logic.CreateTree
{
    public class Node
    {
        public int id;
        public string name;
        public int? parentid;
    }
    public class NewNode
    {
        public int id;
        public string name;
        public int? parentid;
        public List<NewNode> items;
    }

    public static class TreeFns
    {
        public static List<NewNode> CreateNewTree(List<Node> originalList)
        {
            List<NewNode> nodes = originalList.Where(v => v.parentid == null).Select(v => new NewNode() { id = v.id, name = v.name, parentid = v.parentid, items = new List<NewNode>() { } }).ToList();
            foreach (NewNode node in nodes)
            {
                node.items = GetAllLeaves(node, originalList);
            }
            return nodes;
        }

        public static List<NewNode> GetAllLeaves(NewNode val, List<Node> originalList)
        {
            List<NewNode> nodes = originalList.Where(v => v.parentid == val.id).Select(v => new NewNode() { id = v.id, name = v.name, parentid = v.parentid, items = new List<NewNode>() { } }).ToList();
            foreach (NewNode node in nodes)
            {
                node.items = GetAllLeaves(node, originalList);
            }
            return nodes;
        }
    }
}
