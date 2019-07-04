using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * 题目：根据行数据生成树形结构。使用lambda,linq,递归完成，使数据包含id,name,parentid,items
            List<Node> list = new List<Node>() {
                new Node {id=1,name="a",parentid=null },
                new Node {id=2,name="b",parentid=null},
                new Node {id=3,name="c",parentid=1 },
                new Node {id=4,name="d",parentid=null },
                new Node {id=5,name="e",parentid=3 },
                new Node {id=6,name="f",parentid=2 },
                new Node {id=7,name="g",parentid=null }
            };

            List<NewNode> rlt = TreeFns.CreateNewTree(list);

            ViewBag.Cat66 = rlt;
*/
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
