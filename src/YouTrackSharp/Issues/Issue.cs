﻿#region License
// Distributed under the BSD License
//  
// YouTrackSharp Copyright (c) 2010-2011, Hadi Hariri and Contributors
// All rights reserved.
//  
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//     * Redistributions of source code must retain the above copyright
//        notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//        notice, this list of conditions and the following disclaimer in the
//        documentation and/or other materials provided with the distribution.
//     * Neither the name of Hadi Hariri nor the
//        names of its contributors may be used to endorse or promote products
//        derived from this software without specific prior written permission.
//  
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED
//  TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
//  PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL 
//  <COPYRIGHTHOLDER> BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
//  SPECIAL,EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
//  LIMITED  TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
//  DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND  ON ANY
//  THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
//  THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//  
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using JsonFx.Json;

namespace YouTrackSharp.Issues
{
    [TypeConverter(typeof (IssueTypeConverter))]
    public class Issue
    {
        public string Id { get; set; }
        public string ReporterName { get; set; }
        public string FixedInBuild { get; set; }
        public string ProjectShortName { get; set; }
        public string Summary { get; set; }
        public string AssigneeName { get; set; }
        public string[] Priority { get; set; }
        public string Type { get; set; }
        public string Subsystem { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public int Votes { get; set; }
        public string Created { get; set; }
        public string Update { get; set; }
        public IList<Link> Links {get;set;}
        //[JsonName("field")]
        //public Dictionary<string, string> CustomFields { get; set; }
    }


}