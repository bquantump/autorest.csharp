// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Globalization;

namespace Azure.Core
{
    internal class TypeFormatters
    {
        public static string DefaultNumberFormat { get; } = "G";

        public static string ToString(bool value) => value ? "true" : "false";

        public static string ToString(DateTimeOffset value, string format)
        {
            return format switch
            {
                "D" => value.ToString("yyyy-MM-dd"),
                "S" => value.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                "R" => value.ToString("R"),
                "U" => value.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture),
                _ => throw new ArgumentException("Format is not supported", nameof(format))
            };
        }

        public static string ToBase64UrlString(byte[] value)
        {
            var numWholeOrPartialInputBlocks = checked(value.Length + 2) / 3;
            var size = checked(numWholeOrPartialInputBlocks * 4);
            var output = new char[size];

            var numBase64Chars = Convert.ToBase64CharArray(value, 0, value.Length, output, 0);

            // Fix up '+' -> '-' and '/' -> '_'. Drop padding characters.
            int i = 0;
            for (; i < numBase64Chars; i++)
            {
                var ch = output[i];
                if (ch == '+')
                {
                    output[i] = '-';
                }
                else if (ch == '/')
                {
                    output[i] = '_';
                }
                else if (ch == '=')
                {
                    // We've reached a padding character; truncate the remainder.
                    break;
                }
            }

            return new string(output, 0, i);
        }
    }
}