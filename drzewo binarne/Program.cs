using System;


class Program
{
    static void Main(string[] args)
    {
        var tB = new BinTreeNode<char>('B');
        tB.Left = new BinTreeNode<char>('D');
        tB.Right = new BinTreeNode<char>('E');
        var tC = new BinTreeNode<char>('C',
                    new BinTreeNode<char>('F',
                        new BinTreeNode<char>('H'),
                        new BinTreeNode<char>('I')),
                    new BinTreeNode<char>('G')
                 );
        var t = new BinTreeNode<char>('A', tB, tC);
        Console.WriteLine(NoOfNodes(t));
    }
    public static BinTreeNode<char> CreateTreeOfChars()
    {
        BinTreeNode<char> tree = new BinTreeNode<char>('A',
            new BinTreeNode<char>('B',
                new BinTreeNode<char>('D'),
                    new BinTreeNode<char>('E')
                    ),
            new BinTreeNode<char>('C',
                new BinTreeNode<char>('F',
                    new BinTreeNode<char>('H'),
                            new BinTreeNode<char>('I')),
                    new BinTreeNode<char>('G')));
        return tree;
    }

    public static void PrintTree<T>(BinTreeNode<T> p, int level = 0)
    {
        if (p == null) return;
        Console.WriteLine("".PadLeft(level, '.') + p.Value);
        PrintTree(p.Left, level + 1);
        PrintTree(p.Right, level + 1);
    }
    public static int NoOfNodes<T>(BinTreeNode<T> tree)
    {
        int i=0;
        while(tree != null)
        {
            i++;
            tree = tree.Left;
            if (tree == null) tree = tree.Right;
        }
        return i;
    }
}

public class BinTreeNode<T>
{
    public T Value { get; set; }
    public BinTreeNode<T> Left { get; set; }
    public BinTreeNode<T> Right { get; set; }

    public BinTreeNode(T value, BinTreeNode<T> left = null, BinTreeNode<T> right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

