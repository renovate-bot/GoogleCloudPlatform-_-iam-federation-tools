﻿//
// Copyright 2022 Google LLC
//
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
//

using Google.Solutions.WWAuth.Util;
using System.Reflection;
using System.Windows.Forms;

namespace Google.Solutions.WWAuth.View
{
    [SkipCodeCoverage]
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            this.infoLabel.Text =
                $"Workload Authenticator for Windows\n" +
                $"Version {Assembly.GetExecutingAssembly().GetName().Version}\n\n" +
                $"© 2024 Google LLC";
        }
    }
}
