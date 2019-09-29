﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    /// <summary>
    /// A digital signature algorithm
    /// </summary>
    public readonly struct SignatureAlgorithm : IEquatable<SignatureAlgorithm>
    {
        internal const string RS256Value = "RS256";
        internal const string RS384Value = "RS384";
        internal const string RS512Value = "RS512";
        internal const string PS256Value = "PS256";
        internal const string PS384Value = "PS384";
        internal const string PS512Value = "PS512";
        internal const string ES256Value = "ES256";
        internal const string ES384Value = "ES384";
        internal const string ES512Value = "ES512";
        internal const string ES256KValue = "ES256K";

        private readonly string _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureAlgorithm"/> structure.
        /// </summary>
        /// <param name="value"></param>
        public SignatureAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// RSA SHA-256 signature algorithm.
        /// </summary>
        public static readonly SignatureAlgorithm RS256 = new SignatureAlgorithm(RS256Value);

        /// <summary>
        /// RSA SHA-384 signature algorithm.
        /// </summary>
        public static readonly SignatureAlgorithm RS384 = new SignatureAlgorithm(RS384Value);

        /// <summary>
        /// RSA SHA-512 Signature algorithm.
        /// </summary>
        public static readonly SignatureAlgorithm RS512 = new SignatureAlgorithm(RS512Value);

        /// <summary>
        /// RSASSA-PSS using SHA-256 and MGF1 with SHA-256.
        /// </summary>
        public static readonly SignatureAlgorithm PS256 = new SignatureAlgorithm(PS256Value);

        /// <summary>
        /// RSASSA-PSS using SHA-384 and MGF1 with SHA-384.
        /// </summary>
        public static readonly SignatureAlgorithm PS384 = new SignatureAlgorithm(PS384Value);

        /// <summary>
        /// RSASSA-PSS using SHA-512 and MGF1 with SHA-512.
        /// </summary>
        public static readonly SignatureAlgorithm PS512 = new SignatureAlgorithm(PS512Value);

        /// <summary>
        /// ECDSA with a P-256 curve.
        /// </summary>
        public static readonly SignatureAlgorithm ES256 = new SignatureAlgorithm(ES256Value);

        /// <summary>
        /// ECDSA with a P-384 curve.
        /// </summary>
        public static readonly SignatureAlgorithm ES384 = new SignatureAlgorithm(ES384Value);

        /// <summary>
        /// ECDSA with a P-521 curve.
        /// </summary>
        public static readonly SignatureAlgorithm ES512 = new SignatureAlgorithm(ES512Value);

        /// <summary>
        /// ECDSA with a secp256k1 curve.
        /// </summary>
        public static readonly SignatureAlgorithm ES256K = new SignatureAlgorithm(ES256KValue);

        /// <summary>
        /// Determines if two <see cref="SignatureAlgorithm"/> values are the same.
        /// </summary>
        /// <param name="a">The first <see cref="SignatureAlgorithm"/> to compare.</param>
        /// <param name="b">The second <see cref="SignatureAlgorithm"/> to compare.</param>
        /// <returns>True if <paramref name="a"/> and <paramref name="b"/> are the same; otherwise, false.</returns>
        public static bool operator ==(SignatureAlgorithm a, SignatureAlgorithm b) => a.Equals(b);

        /// <summary>
        /// Determines if two <see cref="SignatureAlgorithm"/> values are different.
        /// </summary>
        /// <param name="a">The first <see cref="SignatureAlgorithm"/> to compare.</param>
        /// <param name="b">The second <see cref="SignatureAlgorithm"/> to compare.</param>
        /// <returns>True if <paramref name="a"/> and <paramref name="b"/> are different; otherwise, false.</returns>
        public static bool operator !=(SignatureAlgorithm a, SignatureAlgorithm b) => !a.Equals(b);

        /// <summary>
        /// Converts a string to a <see cref="SignatureAlgorithm"/>.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        public static implicit operator SignatureAlgorithm(string value) => new SignatureAlgorithm(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignatureAlgorithm other && Equals(other);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(SignatureAlgorithm other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => _value;

        internal HashAlgorithm GetHashAlgorithm()
        {
            switch (_value)
            {
                case SignatureAlgorithm.RS256Value:
                case SignatureAlgorithm.PS256Value:
                case SignatureAlgorithm.ES256Value:
                case SignatureAlgorithm.ES256KValue:
                    return SHA256.Create();

                case SignatureAlgorithm.RS384Value:
                case SignatureAlgorithm.PS384Value:
                case SignatureAlgorithm.ES384Value:
                    return SHA384.Create();

                case SignatureAlgorithm.RS512Value:
                case SignatureAlgorithm.PS512Value:
                case SignatureAlgorithm.ES512Value:
                    return SHA512.Create();

                default:
                    throw new InvalidOperationException("Invalid Algorithm");
            }
        }

        internal HashAlgorithmName GetHashAlgorithmName()
        {
            switch (_value)
            {
                case SignatureAlgorithm.RS256Value:
                case SignatureAlgorithm.PS256Value:
                case SignatureAlgorithm.ES256Value:
                case SignatureAlgorithm.ES256KValue:
                    return HashAlgorithmName.SHA256;

                case SignatureAlgorithm.RS384Value:
                case SignatureAlgorithm.PS384Value:
                case SignatureAlgorithm.ES384Value:
                    return HashAlgorithmName.SHA384;

                case SignatureAlgorithm.RS512Value:
                case SignatureAlgorithm.PS512Value:
                case SignatureAlgorithm.ES512Value:
                    return HashAlgorithmName.SHA512;
                default:

                    return default;
            }
        }

        internal ref readonly KeyCurveName GetEcKeyCurveName()
        {
            switch (_value)
            {
                case SignatureAlgorithm.ES256Value:
                    return ref KeyCurveName.P256;

                case SignatureAlgorithm.ES256KValue:
                    return ref KeyCurveName.P256K;

                case SignatureAlgorithm.ES384Value:
                    return ref KeyCurveName.P384;

                case SignatureAlgorithm.ES512Value:
                    return ref KeyCurveName.P521;

                default:
                    return ref KeyCurveName.s_default;
            }
        }

        internal RSASignaturePadding GetRsaSignaturePadding()
        {
            switch (_value)
            {
                case SignatureAlgorithm.RS256Value:
                case SignatureAlgorithm.RS384Value:
                case SignatureAlgorithm.RS512Value:
                    return RSASignaturePadding.Pkcs1;

                case SignatureAlgorithm.PS256Value:
                case SignatureAlgorithm.PS384Value:
                case SignatureAlgorithm.PS512Value:
                    return RSASignaturePadding.Pss;

                default:
                    return null;
            }
        }
    }
}