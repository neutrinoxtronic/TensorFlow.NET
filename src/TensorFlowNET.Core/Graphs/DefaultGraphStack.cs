﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

using System;
using System.Collections.Generic;

namespace Tensorflow
{
    /// <summary>
    ///     Serves as a stack for determining current default graph.
    /// </summary>
    public class DefaultGraphStack
    {
        Stack<Graph> _stack = new Stack<Graph>();

        public Graph get_default()
        {
            if (_stack.Count == 0)
                _stack.Push(new Graph());

            return _stack.Peek();
        }

        public Graph get_controller(Graph g)
        {
            _stack.Push(g);
            return g;
        }

        public Graph peak_controller()
        {
            if (_stack.Count == 0)
                return null;
            return _stack.Peek();
        }

        public void pop()
        {
            _stack.Pop();
        }

        public void reset()
        {
            _stack.Clear();
        }
    }
}