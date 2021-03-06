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
    /// <para>Changed who can create groups.</para>
    /// </summary>
    public class GroupUserManagementChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupUserManagementChangePolicyDetails> Encoder = new GroupUserManagementChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupUserManagementChangePolicyDetails> Decoder = new GroupUserManagementChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="GroupUserManagementChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New group users management policy.</param>
        /// <param name="previousValue">Previous group users management policy. Might be
        /// missing due to historical data gap.</param>
        public GroupUserManagementChangePolicyDetails(GroupsUserManagementPolicy newValue,
                                                      GroupsUserManagementPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="GroupUserManagementChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupUserManagementChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New group users management policy.</para>
        /// </summary>
        public GroupsUserManagementPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous group users management policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public GroupsUserManagementPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupUserManagementChangePolicyDetails" />.</para>
        /// </summary>
        private class GroupUserManagementChangePolicyDetailsEncoder : enc.StructEncoder<GroupUserManagementChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupUserManagementChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.GroupsUserManagementPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.GroupsUserManagementPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupUserManagementChangePolicyDetails" />.</para>
        /// </summary>
        private class GroupUserManagementChangePolicyDetailsDecoder : enc.StructDecoder<GroupUserManagementChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="GroupUserManagementChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupUserManagementChangePolicyDetails Create()
            {
                return new GroupUserManagementChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupUserManagementChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.GroupsUserManagementPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.GroupsUserManagementPolicy.Decoder.Decode(reader);
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
