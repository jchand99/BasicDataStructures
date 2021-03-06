/*
Author: Jacob Chandler
File: ArrayStack.cs
Version: 1.0.1
Description: This file is the class file for the ArrayStack object which implements IStack.
Date of Comment: 06:01:2018
 */

using System;

namespace DataStructures.Stacks {

    public class ArrayStack<E> : IStack<E> {
        private E[] StackOfElements;
        private const int DEFAULT_CAPACITY = 10;
        private int TopElement;
        private bool Initialized = false;
        public int Length { get; private set; }
        public int Count { get; private set; }

        public ArrayStack() : this(DEFAULT_CAPACITY) { }

        public ArrayStack(int capacity) {
            StackOfElements = new E[capacity];
            Length = StackOfElements.Length;
            Count = 0;
            TopElement = -1;
            Initialized = true;
        }

        public void Empty() {
            CheckInitialization();

            if (IsEmpty()) {
                throw new InvalidOperationException("Stack is Empty.");
            }

            for (int i = 0; i < Count; i++) {
                StackOfElements[i] = default(E);
                TopElement--;
            }
            Count = 0;
        }

        public E Peek() {
            CheckInitialization();

            return StackOfElements[TopElement];
        }

        public E Pop() {
            CheckInitialization();

            if (IsEmpty()) {
                throw new InvalidOperationException("Stack is Empty.");
            }

            E tmp = StackOfElements[TopElement];
            StackOfElements[TopElement] = default(E);
            Count--;
            TopElement--;
            return tmp;
        }

        public void Push(E element) {
            CheckInitialization();

            if (Count >= StackOfElements.Length) {
                StackOfElements = ReSize();
            }

            StackOfElements[TopElement + 1] = element;
            Count++;
            TopElement++;
        }

        public bool IsEmpty() {
            CheckInitialization();

            return TopElement < 0;
        }

        private void CheckInitialization() {
            if (!Initialized) {
                throw new InvalidOperationException("Stack not initialized properly.");
            }
        }

        private E[] ReSize() {
            E[] tmp = new E[StackOfElements.Length * 2];

            for (int i = 0; i < StackOfElements.Length; i++) {
                tmp[i] = StackOfElements[i];
            }

            Length = tmp.Length;
            return tmp;
        }
    }
}