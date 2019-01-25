﻿// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System;
using FlexiMvvm.Bindings;
using FlexiMvvm.ViewModels;
using JetBrains.Annotations;

namespace FlexiMvvm.Views.Core
{
    public interface IBindableView<TViewModel> : IView<TViewModel>
        where TViewModel : class, IViewModel
    {
        [CanBeNull]
        IDisposable BindingSet { get; }

        void ExecuteBindings();

        void Bind([NotNull] BindingSet<TViewModel> bindingSet);
    }
}
