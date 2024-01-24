﻿using System;

/// <summary>
/// class Queue t
/// </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    /// <summary> creation of node </summary>
    public class Node
    {
        public T value;
        public Node next = null;

        public Node(T stri)
        {
            value = stri;
        }

    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }

        else
        {
            tail.next = newNode;
            tail = newNode;
            
        }
        
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            tail.value = head.value;
            head = head.next;
            count--;
            return tail.value;
        }
    }

    /// <summary> Check type of T </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> returns count </summary>
    public int Count()
    {
        return count;
    }
}