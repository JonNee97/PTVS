// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

#if DEV16_OR_LATER
using Microsoft.WebTools.Languages.Html.Artifacts;
using Microsoft.WebTools.Languages.Html.Editor.ContentType.Handlers;
using Microsoft.WebTools.Languages.Html.Editor.Tree;
#else
using Microsoft.Html.Core.Artifacts;
using Microsoft.Html.Editor.ContentType.Handlers;
using Microsoft.Html.Editor.Tree;
#endif

namespace Microsoft.PythonTools.Django.TemplateParsing {
    internal class TemplateContentTypeHandler : HtmlServerCodeContentTypeHandler {
        public override void Init(HtmlEditorTree editorTree) {
            base.Init(editorTree);
            ContainedLanguageBlockHandler = new TemplateBlockHandler(editorTree);
        }

        public override ArtifactCollection CreateArtifactCollection() {
            return new TemplateArtifactCollection();
        }
    }
}