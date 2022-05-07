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
        Print(t);
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

    public static void Print<T>(BinTreeNode<T> p, int level = 0)
    {
        if (p == null) return;
        Print(p.Left, level + 1);
        Console.WriteLine("".PadLeft(level, '.') + p.Value);
        Print(p.Right, level + 1);
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

