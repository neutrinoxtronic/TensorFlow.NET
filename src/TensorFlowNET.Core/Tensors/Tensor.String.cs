﻿using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static Tensorflow.Binding;

namespace Tensorflow
{
    public partial class Tensor
    {
        const int TF_TSRING_SIZE = 24;

        public SafeStringTensorHandle StringTensor(string[] strings, Shape shape)
        {
            // convert string array to byte[][]
            var buffer = new byte[strings.Length][];
            for (var i = 0; i < strings.Length; i++)
                buffer[i] = Encoding.UTF8.GetBytes(strings[i]);

            return StringTensor(buffer, shape);
        }

        public SafeStringTensorHandle StringTensor(byte[][] buffer, Shape shape)
        {
            var handle = c_api.TF_AllocateTensor(TF_DataType.TF_STRING,
                shape.dims,
                shape.ndim,
                (ulong)shape.size * TF_TSRING_SIZE);

            var tstr = c_api.TF_TensorData(handle);
#if TRACK_TENSOR_LIFE
            print($"New StringTensor {handle} Data: 0x{tstr.ToString("x16")}");
#endif
            for (int i = 0; i < buffer.Length; i++)
            {
                c_api.TF_StringInit(tstr);
                c_api.TF_StringCopy(tstr, buffer[i], buffer[i].Length);
                // var data = c_api.TF_StringGetDataPointer(tstr);
                tstr += TF_TSRING_SIZE;
            }

            return new SafeStringTensorHandle(handle, shape);
        }

        public string[] StringData()
        {
            var buffer = StringBytes();

            var _str = new string[buffer.Length];
            for (int i = 0; i < _str.Length; i++)
                _str[i] = Encoding.UTF8.GetString(buffer[i]);

            return _str;
        }

        public string StringData(int index)
        {
            var bytes = StringBytes(index);
            return Encoding.UTF8.GetString(bytes);
        }

        public byte[] StringBytes(int index)
        {
            if (dtype != TF_DataType.TF_STRING)
                throw new InvalidOperationException($"Unable to call StringData when dtype != TF_DataType.TF_STRING (dtype is {dtype})");

            byte[] buffer = new byte[0];
            var tstrings = TensorDataPointer;
            for (int i = 0; i < shape.size; i++)
            {
                if(index == i)
                {
                    var data = c_api.TF_StringGetDataPointer(tstrings);
                    var len = c_api.TF_StringGetSize(tstrings);
                    buffer = new byte[len];
                    // var capacity = c_api.TF_StringGetCapacity(tstrings);
                    // var type = c_api.TF_StringGetType(tstrings);
                    Marshal.Copy(data, buffer, 0, Convert.ToInt32(len));
                    break;
                }
                tstrings += TF_TSRING_SIZE;
            }
            return buffer;
        }

        public byte[][] StringBytes()
        {
            if (dtype != TF_DataType.TF_STRING)
                throw new InvalidOperationException($"Unable to call StringData when dtype != TF_DataType.TF_STRING (dtype is {dtype})");

            //
            // TF_STRING tensors are encoded with a table of 8-byte offsets followed by TF_StringEncode-encoded bytes.
            // [offset1, offset2,...,offsetn, s1size, s1bytes, s2size, s2bytes,...,snsize,snbytes]
            //
            long size = 1;
            foreach (var s in shape.dims)
                size *= s;

            var buffer = new byte[size][];
            var tstrings = TensorDataPointer;
            for (int i = 0; i < buffer.Length; i++)
            {
                var data = c_api.TF_StringGetDataPointer(tstrings);
                var len = c_api.TF_StringGetSize(tstrings);
                buffer[i] = new byte[len];
                // var capacity = c_api.TF_StringGetCapacity(tstrings);
                // var type = c_api.TF_StringGetType(tstrings);
                Marshal.Copy(data, buffer[i], 0, Convert.ToInt32(len));
                tstrings += TF_TSRING_SIZE;
            }
            return buffer;
        }
    }
}
