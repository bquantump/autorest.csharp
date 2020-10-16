// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace network.Models
{
    /// <summary> IP address allocation method. </summary>
    internal readonly partial struct IPAllocationMethod : IEquatable<IPAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="IPAllocationMethod"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "Static";
        private const string DynamicValue = "Dynamic";

        /// <summary> Static. </summary>
        public static IPAllocationMethod Static { get; } = new IPAllocationMethod(StaticValue);
        /// <summary> Dynamic. </summary>
        public static IPAllocationMethod Dynamic { get; } = new IPAllocationMethod(DynamicValue);
        /// <summary> Determines if two <see cref="IPAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(IPAllocationMethod left, IPAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(IPAllocationMethod left, IPAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IPAllocationMethod"/>. </summary>
        public static implicit operator IPAllocationMethod(string value) => new IPAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
