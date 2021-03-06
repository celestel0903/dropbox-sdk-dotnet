// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled or disabled commenting on team files.</para>
    /// </summary>
    public class FileCommentsChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileCommentsChangePolicyDetails> Encoder = new FileCommentsChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileCommentsChangePolicyDetails> Decoder = new FileCommentsChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileCommentsChangePolicyDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="newValue">New commenting on team files policy.</param>
        /// <param name="previousValue">Previous commenting on team files policy. Might be
        /// missing due to historical data gap.</param>
        public FileCommentsChangePolicyDetails(EnableDisableChangePolicy newValue,
                                               EnableDisableChangePolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileCommentsChangePolicyDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileCommentsChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New commenting on team files policy.</para>
        /// </summary>
        public EnableDisableChangePolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous commenting on team files policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public EnableDisableChangePolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileCommentsChangePolicyDetails" />.</para>
        /// </summary>
        private class FileCommentsChangePolicyDetailsEncoder : enc.StructEncoder<FileCommentsChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileCommentsChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileCommentsChangePolicyDetails" />.</para>
        /// </summary>
        private class FileCommentsChangePolicyDetailsDecoder : enc.StructDecoder<FileCommentsChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileCommentsChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileCommentsChangePolicyDetails Create()
            {
                return new FileCommentsChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileCommentsChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
