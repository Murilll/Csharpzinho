// using System;

// Lista<string> Pilha = new Lista<string>();
// Pilha.Push("Teste");
// Pilha.Push("Teste1");
// Pilha.Push("Teste2");
// Pilha.Size();
// // Pilha.Push("aimeudues");
// // Pilha.IsEmpty("");

// foreach (var i in Pilha.stack)
//     Console.WriteLine(i);

// public class Lista<T>
// {
//     public T[] stack = new T[10];
//     private int index { get; set; } = 0;
    
//     public void Push(T item)
//     {
//         index++;
//         stack[index] = item;
//     }

//     public void Pop()
//     {
//         if (index < 0)
//             return;

//         index = index - 1;
//     }

//     public bool IsEmpty()
//     {
//         if (index < 0)
//             return true;
//         else
//             return false;
//     }

//     public int Size()
//     {
//         return index;
//     }

//     public void Clear()
//     {
//         index = 0;

//         // or

//         // for (int i = 0; i < stack.Count(); i++)
//         //     stack[i] = default(T);
//         // index = -1;
//     }

//     public override string ToString()
//     {
//         string a = "";

//         for (int i = 0; i < index; i++)
//         {
//             a += $"{i} - {stack[i]}";
//         }

//         return base.ToString();
//     }
// }