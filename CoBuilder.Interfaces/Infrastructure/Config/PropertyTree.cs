﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Windows.Forms;
using StructureMap.Pipeline;

namespace CoBuilder.Service.Infrastructure.Config
{
    public class PropertyTree : Tree<IDefinition>
    {
        public PropertyTree(DefinitionNode root) : base(root)
        {
        }
    }

    public class DefinitionNode : TreeNode<IDefinition>
    {
        public DefinitionNode()
        {
        }

        public DefinitionNode(IDefinition value) : base(value)
        {
        }

        public DefinitionNode(IDefinition info, params TreeNode<IDefinition>[] children) : base(info, children)
        {
        }

        public DefinitionNode(IDefinition info, DefinitionNode parent) : base(info, parent)
        {
        }

        public DefinitionNode(IDefinition info, NodeList<IDefinition> children) : base(info, children)
        {
        }
    }

    public class Tree<T>
    {
        public Tree()
        {
            Root = null;
        }

        public Tree(TreeNode<T> root)
        {
            if (root == null) throw new ArgumentNullException(nameof(root));
            Root = root;
        }

        public TreeNode<T> Root { get; protected set; }

        public virtual void Clear()
        {
            Root = null;
        }

        public Tree<T> SubTree(TreeNode<T> root)
        {
            return new Tree<T>(root);
        }
    }

    public class TreeNode<T>
    {
        private TreeNode<T> _parent;

        public TreeNode()
        {

        }

        public TreeNode(T info)
        {
            Value = info;
        }

        public TreeNode(T info, NodeList<T> children) : this(info)
        {
            Children = children;
        }

        public TreeNode(T info, TreeNode<T> parent) : this(info)
        {
            _parent = parent.AddChild(this);
        }

        public TreeNode(T info, params TreeNode<T>[] children) : this(info)
        {
#pragma warning disable RECS0021 // Warns about calls to virtual member functions occuring in the constructor
            AddChildren(children);
#pragma warning restore RECS0021 // Warns about calls to virtual member functions occuring in the constructor
        }


        public TreeNode<T> Parent
        {
            get { return _parent; }
            set
            {
                Parent.Children.Remove(this);
                value.AddChild(this);
            }
        }

        public NodeList<T> Children { get; set; }

        public bool HasChildren => Children != null && Children.Count > 0;
        public T Value { get; protected set; }

        public virtual TreeNode<T> AddChild(TreeNode<T> child)
        {
            var temp = Children ?? new NodeList<T>();
            PrivateAddChild(child, temp);
            Children = temp;
            return this;
        }

        public virtual TreeNode<T> AddChildren(params TreeNode<T>[] children)
        {
            var temp = Children ?? new NodeList<T>();
            foreach (var child in children)
            {
                PrivateAddChild(child, temp);
            }
            Children = temp;

            return this;
        }

        public virtual TreeNode<T> RemoveChild(TreeNode<T> child, RemoveChildOptions options)
        {
            switch (options)
            {
                case RemoveChildOptions.RemoveBranch:
                    //explicitly delete to free up memory?
                    break;
                case RemoveChildOptions.ShiftBranchUp:
                    foreach (var node in child.Children)
                    {
                        AddChild((TreeNode<T>) node);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(options), options, null);
            }
            PrivateRemoveChild(child);
            return this;
        }

        public virtual TreeNode<T> RemoveChildren(RemoveChildOptions options, params TreeNode<T>[] children)
        {
            foreach (var child in children)
            {
                RemoveChild(child, options);
            }
            return this;
        }

        private void PrivateAddChild(TreeNode<T> child, NodeList<T> children)
        {
            if (child == null) throw new ArgumentNullException(nameof(child));
            children.Add(child);
            child._parent = this;
        }

        private void PrivateRemoveChild(TreeNode<T> child)
        {
            if (child == null) throw new ArgumentNullException(nameof(child));
            Children.Remove(child);
            child._parent = null;
        }
    }

    public class NodeList<T> : Collection<TreeNode<T>>
    {
        public NodeList()
        {
        }

        public NodeList(int initialSize)
        {
            // Add the specified number of items
            for (var i = 0; i < initialSize; i++)
                Items.Add(default(TreeNode<T>));
        }

        public TreeNode<T> FindByValue(T value)
        {
            // search the list for the value
            return Items.FirstOrDefault(node => node.Value.Equals(value));
        }
    }

    public enum RemoveChildOptions
    {
        RemoveBranch,
        ShiftBranchUp
    }


}