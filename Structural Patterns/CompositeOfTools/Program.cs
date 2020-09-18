using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CompositeOfTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Component tool = new CompositeTool("motor");
            Component tool1 = new CompositeTool("virabrequin");
            Component tool2 = new CompositeTool("ferro");
            Component tool3 = new CompositeTool("aluminio");

            tool.add(tool1);
            tool1.add(tool2);
            tool1.add(tool3);

            List<Component> tools = new List<Component>();
            tools.Add(tool);
            tools.Add(tool1);
            tools.Add(tool2);
            tools.Add(tool3);

            foreach (CompositeTool item in tools)
            {
                Console.WriteLine($"Peça: {item.name} \n quantidades de peças para produzir: {item.list.Count}");
            }
        }

    }
    public abstract class Component
    {
        public string name;
        
        public Component(string name)
        {
            this.name = name;
        }

        public virtual void add(Component component)
        {
            throw new Exception();
        }

        public virtual void remove(Component component)
        {
            throw new Exception();
        }

        public virtual Component getChild(int i)
        {
            throw new Exception();
        }
    }

    public class CompositeTool : Component
    {
        public List<Component> list = new List<Component>();

        public CompositeTool(string name) : base(name)
        {
        }

        public override void add(Component component)
        {
            if (component != null)
                list.Add(component);
        }

        public override void remove(Component component)
        {
            if (list.Contains(component))
                list.Remove(component);
        }

        public override Component getChild(int i)
        {
            return (Component)list[i];
        }
    }    
}
