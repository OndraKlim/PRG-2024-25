using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Node
    {
        public int index;
        public List<Node> neighbours;


        public Node(int index)
        {
            this.index = index;
            neighbours = new List<Node>();
        }

        public void AddNeighbour (Node neighbour)
        {
            if (neighbours.Contains(neighbour))
            {
                Console.WriteLine("This neighbour is already present");
            }
            else
            {
                neighbours.Add(neighbour);
            }

        

        }
        public void AddNeighbours(List<Node> newNeighbours)
        {
            foreach (Node neighbour in newNeighbours)
            {
                AddNeighbour(neighbour);
            }
        }

        public void PrintNeighbours()
        {
            Console.Write("neighbours of node " + index + "; ");
            foreach (Node neighbour in neighbours)
            {
                Console.Write(neighbour.index + " ");
            }
            Console.WriteLine();

        }

        public Node FindNeighbour(int nextindex)
        {
            foreach (Node neighbour in neighbours)
            {
                if (neighbour.index == nextindex)
                {
                    return neighbour;
                }
            }
            Console.WriteLine("Invalid neighbour, staying in the same node");
            return this;
        }
    }
}
