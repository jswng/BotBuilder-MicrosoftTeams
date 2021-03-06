﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
//
// Microsoft Bot Framework: http://botframework.com
// Microsoft Teams: https://dev.office.com/microsoft-teams
//
// Bot Builder SDK GitHub:
// https://github.com/Microsoft/BotBuilder
//
// Bot Builder SDK Extensions for Teams
// https://github.com/OfficeDev/BotBuilder-MicrosoftTeams
//
// Copyright (c) Microsoft Corporation
// All rights reserved.
//
// MIT License:
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
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Content type for <see cref="FileListItem"/>
    /// </summary>
    public partial class FileListItem
    {
        /// <summary>
        /// Content type to be used in the type property.
        /// </summary>
        public const string ContentType = "file";
    }

    /// <summary>
    /// Content type for <see cref="O365ConnectorCard"/>
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Using one file for all additional properties.")]
    public partial class O365ConnectorCard
    {
        /// <summary>
        /// Content type to be used in the type property.
        /// </summary>
        public const string ContentType = "application/vnd.microsoft.teams.card.o365connector";
    }

    /// <summary>
    /// Content type for <see cref="O365ConnectorCardViewAction"/>
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Using one file for all additional properties.")]
    public partial class O365ConnectorCardViewAction
    {
        /// <summary>
        /// Content type to be used in the @type property.
        /// </summary>
        public const string ContentType = "viewAction";
    }

    /////// <summary>
    /////// Content type for <see cref="PersonCard"/>
    /////// </summary>
    ////[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Using one file for all additional properties.")]
    ////public partial class PersonCard
    ////{
    ////    /// <summary>
    ////    /// Content type to be used in the type property.
    ////    /// </summary>
    ////    public const string ContentType = "application/vnd.microsoft.teams.card.profile";
    ////}

    /////// <summary>
    /////// Content type for <see cref="PersonListItem"/>
    /////// </summary>
    ////[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Using one file for all additional properties.")]
    ////public partial class PersonListItem
    ////{
    ////    /// <summary>
    ////    /// Content type to be used in the type property.
    ////    /// </summary>
    ////    public const string ContentType = "person";
    ////}

    /////// <summary>
    /////// Content type for <see cref="SectionListItem"/>
    /////// </summary>
    ////[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Using one file for all additional properties.")]
    ////public partial class SectionListItem
    ////{
    ////    /// <summary>
    ////    /// Content type to be used in the type property.
    ////    /// </summary>
    ////    public const string ContentType = "section";
    ////}

    /////// <summary>
    /////// Content type for <see cref="ListCard"/>
    /////// </summary>
    ////[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Using one file for all additional properties.")]
    ////public partial class ListCard
    ////{
    ////    /// <summary>
    ////    /// Content type of List Card
    ////    /// </summary>
    ////    public const string ContentType = "application/vnd.microsoft.teams.card.list";
    ////}
}
