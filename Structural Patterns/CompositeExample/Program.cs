using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Component Folder = new CompositeFolder();

            Folder.add(new CompositeFile(10));
            Folder.add(new CompositeFile(20));

            Console.WriteLine($"Folder has {Folder.getSize()} KB");
        }
    }


    public abstract class Component
    {                
        private string nome { get; set; }
        private double tamanho { get; set; }    

        public abstract float getSize();

        public virtual void add(Component Component)
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
    public class CompositeFolder : Component
    {        
        protected List<Component> list = new List<Component>();

        public override void add(Component component)
        {
            list.Add(component);
        }

        public override void remove (Component component)
        {
            list.Remove(component);
        }

        public override Component getChild(int i)
        {
            return (Component) list[i];
        }        

        public override float getSize()
        {
            float totalSize = 0;
                foreach (Component item in list)
                {
                    totalSize += item.getSize();
                }

                return totalSize;
        }
    }

    public class CompositeFile : Component
    {
        private float size; 

        public CompositeFile(float size) : base()
        {            
            this.size = size;
        }        

        public override float getSize()
        {
            return size;
        }
    }
    
}
