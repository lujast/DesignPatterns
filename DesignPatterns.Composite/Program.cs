using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            IComponent root = new Composite("root");
            IComponent leftLeaf = new Leaf("LeftLeaf");
            IComponent rightComposite = new Composite("RightComposite");
            IComponent level2LeftLeaf = new Leaf("LevelLeftLeaf");
            IComponent level2CenterLeaf = new Leaf("Level2CenterLeaf");
            IComponent level2RightLeaf = new Leaf("Level2RightLeaf");
            (root as Composite).AddComponent(leftLeaf);
            (root as Composite).AddComponent(rightComposite);
            (rightComposite as Composite).AddComponent(level2LeftLeaf);
            (rightComposite as Composite).AddComponent(level2CenterLeaf);
            (rightComposite as Composite).AddComponent(level2RightLeaf);

            root.Operation();

            (root as Composite).RemoveComponent(rightComposite);
            Console.WriteLine();
            root.Operation();
        }
    }
}
