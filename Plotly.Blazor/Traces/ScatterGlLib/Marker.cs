/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ScatterGlLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>marker.colorscale</c>. Has an
        ///     effect only if in <c>marker.color</c>is set to a numerical array. In case
        ///     <c>colorscale</c> is unspecified or <c>autocolorscale</c> is true, the default
        ///      palette will be chosen according to whether numbers in the <c>color</c>
        ///     array are all positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>marker.color</c>) or the bounds set in <c>marker.cmin</c>
        ///     and <c>marker.cmax</c>  Has an effect only if in <c>marker.color</c>is set
        ///     to a numerical array. Defaults to <c>false</c> when <c>marker.cmin</c> and
        ///     <c>marker.cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.color</c>
        ///     and if set, <c>marker.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public decimal? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>marker.cmin</c> and/or
        ///     <c>marker.cmax</c> to be equidistant to this point. Has an effect only if
        ///     in <c>marker.color</c>is set to a numerical array. Value should have the
        ///     same units as in <c>marker.color</c>. Has no effect when <c>marker.cauto</c>
        ///     is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public decimal? CMid { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.color</c>
        ///     and if set, <c>marker.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public decimal? CMin { get; set;} 

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public IList<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in <c>marker.color</c>is set
        ///     to a numerical array. The colorscale must be an array containing arrays
        ///     mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color
        ///     string. At minimum, a mapping for the lowest (0) and highest (1) values
        ///     are required. For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>marker.cmin</c>
        ///     and <c>marker.cmax</c>. Alternatively, <c>colorscale</c> may be a palette
        ///     name string of the following list: Blackbody,Bluered,Blues,Cividis,Earth,Electric,Greens,Greys,Hot,Jet,Picnic,Portland,Rainbow,RdBu,Reds,Viridis,YlGnBu,YlOrRd.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>color</c>.
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        [Array]
        public IList<decimal?> OpacityArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>opacity</c>.
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. If true, <c>marker.cmin</c> will correspond to
        ///     the last color in the array and <c>marker.cmax</c> will correspond to the
        ///     first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace. Has an
        ///     effect only if in <c>marker.color</c>is set to a numerical array.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public decimal? Size { get; set;} 

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        [Array]
        public IList<decimal?> SizeArray { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the minimum size (in px) of the rendered marker points.
        /// </summary>
        [JsonPropertyName(@"sizemin")]
        public decimal? SizeMin { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the rule for which the data in <c>size</c> is converted to pixels.
        /// </summary>
        [JsonPropertyName(@"sizemode")]
        public Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.SizeModeEnum? SizeMode { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the scale factor used to determine the rendered size of marker points. Use
        ///     with <c>sizemin</c> and <c>sizemode</c>.
        /// </summary>
        [JsonPropertyName(@"sizeref")]
        public decimal? SizeRef { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>size</c>.
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string SizeSrc { get; set;} 

        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.SymbolEnum? Symbol { get; set;} 

        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.SymbolEnum?> SymbolArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>symbol</c>.
        /// </summary>
        [JsonPropertyName(@"symbolsrc")]
        public string SymbolSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Marker other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Marker other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AutoColorScale == other.AutoColorScale ||
                    AutoColorScale != null &&
                    AutoColorScale.Equals(other.AutoColorScale)
                ) && 
                (
                    CAuto == other.CAuto ||
                    CAuto != null &&
                    CAuto.Equals(other.CAuto)
                ) && 
                (
                    CMax == other.CMax ||
                    CMax != null &&
                    CMax.Equals(other.CMax)
                ) && 
                (
                    CMid == other.CMid ||
                    CMid != null &&
                    CMid.Equals(other.CMid)
                ) && 
                (
                    CMin == other.CMin ||
                    CMin != null &&
                    CMin.Equals(other.CMin)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Equals(ColorArray, other.ColorArray) ||
                    ColorArray != null && other.ColorArray != null &&
                    ColorArray.SequenceEqual(other.ColorArray)
                ) &&
                (
                    ColorAxis == other.ColorAxis ||
                    ColorAxis != null &&
                    ColorAxis.Equals(other.ColorAxis)
                ) && 
                (
                    ColorBar == other.ColorBar ||
                    ColorBar != null &&
                    ColorBar.Equals(other.ColorBar)
                ) && 
                (
                    ColorScale == other.ColorScale ||
                    ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    ColorSrc == other.ColorSrc ||
                    ColorSrc != null &&
                    ColorSrc.Equals(other.ColorSrc)
                ) && 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Equals(OpacityArray, other.OpacityArray) ||
                    OpacityArray != null && other.OpacityArray != null &&
                    OpacityArray.SequenceEqual(other.OpacityArray)
                ) &&
                (
                    OpacitySrc == other.OpacitySrc ||
                    OpacitySrc != null &&
                    OpacitySrc.Equals(other.OpacitySrc)
                ) && 
                (
                    ReverseScale == other.ReverseScale ||
                    ReverseScale != null &&
                    ReverseScale.Equals(other.ReverseScale)
                ) && 
                (
                    ShowScale == other.ShowScale ||
                    ShowScale != null &&
                    ShowScale.Equals(other.ShowScale)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Equals(SizeArray, other.SizeArray) ||
                    SizeArray != null && other.SizeArray != null &&
                    SizeArray.SequenceEqual(other.SizeArray)
                ) &&
                (
                    SizeMin == other.SizeMin ||
                    SizeMin != null &&
                    SizeMin.Equals(other.SizeMin)
                ) && 
                (
                    SizeMode == other.SizeMode ||
                    SizeMode != null &&
                    SizeMode.Equals(other.SizeMode)
                ) && 
                (
                    SizeRef == other.SizeRef ||
                    SizeRef != null &&
                    SizeRef.Equals(other.SizeRef)
                ) && 
                (
                    SizeSrc == other.SizeSrc ||
                    SizeSrc != null &&
                    SizeSrc.Equals(other.SizeSrc)
                ) && 
                (
                    Symbol == other.Symbol ||
                    Symbol != null &&
                    Symbol.Equals(other.Symbol)
                ) && 
                (
                    Equals(SymbolArray, other.SymbolArray) ||
                    SymbolArray != null && other.SymbolArray != null &&
                    SymbolArray.SequenceEqual(other.SymbolArray)
                ) &&
                (
                    SymbolSrc == other.SymbolSrc ||
                    SymbolSrc != null &&
                    SymbolSrc.Equals(other.SymbolSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AutoColorScale != null) hashCode = hashCode * 59 + AutoColorScale.GetHashCode();
                if (CAuto != null) hashCode = hashCode * 59 + CAuto.GetHashCode();
                if (CMax != null) hashCode = hashCode * 59 + CMax.GetHashCode();
                if (CMid != null) hashCode = hashCode * 59 + CMid.GetHashCode();
                if (CMin != null) hashCode = hashCode * 59 + CMin.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (ColorAxis != null) hashCode = hashCode * 59 + ColorAxis.GetHashCode();
                if (ColorBar != null) hashCode = hashCode * 59 + ColorBar.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (OpacityArray != null) hashCode = hashCode * 59 + OpacityArray.GetHashCode();
                if (OpacitySrc != null) hashCode = hashCode * 59 + OpacitySrc.GetHashCode();
                if (ReverseScale != null) hashCode = hashCode * 59 + ReverseScale.GetHashCode();
                if (ShowScale != null) hashCode = hashCode * 59 + ShowScale.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                if (SizeArray != null) hashCode = hashCode * 59 + SizeArray.GetHashCode();
                if (SizeMin != null) hashCode = hashCode * 59 + SizeMin.GetHashCode();
                if (SizeMode != null) hashCode = hashCode * 59 + SizeMode.GetHashCode();
                if (SizeRef != null) hashCode = hashCode * 59 + SizeRef.GetHashCode();
                if (SizeSrc != null) hashCode = hashCode * 59 + SizeSrc.GetHashCode();
                if (Symbol != null) hashCode = hashCode * 59 + Symbol.GetHashCode();
                if (SymbolArray != null) hashCode = hashCode * 59 + SymbolArray.GetHashCode();
                if (SymbolSrc != null) hashCode = hashCode * 59 + SymbolSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Marker left, Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Marker left, Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            return this.Copy();
        }
    }
}