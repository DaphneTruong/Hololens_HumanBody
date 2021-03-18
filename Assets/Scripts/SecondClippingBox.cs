using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Utilities
{
    [ExecuteInEditMode]
    public class SecondClippingBox : ClippingBox
    {
        /// <inheritdoc />
        protected override string Keyword
        {
            get { return "_CLIPPING_BOX2"; }
        }

        /// <inheritdoc />
        protected override string ClippingSideProperty
        {
            get { return "_ClipBoxSide2"; }
        }

        /// <inheritdoc />
        protected override void Initialize()
        {
            base.Initialize();

            clipBoxSizeID = Shader.PropertyToID("_ClipBoxSize2");
            clipBoxInverseTransformID = Shader.PropertyToID("_ClipBoxInverseTransform2");
        }
    }
}

