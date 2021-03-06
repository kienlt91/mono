﻿//
// ProjectTaskElement.cs
//
// Author:
//   Leszek Ciesielski (skolima@gmail.com)
//
// (C) 2011 Leszek Ciesielski
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Collections.Generic;
using System;

namespace Microsoft.Build.Construction
{
        public class ProjectTaskElement : ProjectElementContainer
        {
                public string ContinueOnError { get; set; }
                public string Name {
                        get {
                                throw new NotImplementedException ();
                        }
                }
                public ICollection<ProjectOutputElement> Outputs {
                        get {
                                throw new NotImplementedException ();
                        }
                }
                public IDictionary<string, string> Parameters {
                        get {
                                throw new NotImplementedException ();
                        }
                }
                public ProjectOutputElement AddOutputItem (string taskParameter, string itemType)
                {
                        throw new NotImplementedException ();
                }
                public ProjectOutputElement AddOutputItem (string taskParameter, string itemType, string condition)
                {
                        throw new NotImplementedException ();
                }
                public ProjectOutputElement AddOutputProperty (string taskParameter, string propertyName,
                                                               string condition)
                {
                        throw new NotImplementedException ();
                }
                public string GetParameter (string name)
                {
                        throw new NotImplementedException ();
                }
                public void RemoveAllParameters ()
                {
                }
                public void RemoveParameter (string name)
                {
                }
                public void SetParameter (string name, string unevaluatedValue)
                {
                }
                internal override string XmlName {
                        get {
                                throw new NotImplementedException ();
                        }
                }
        }
}
