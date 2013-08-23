﻿using Jint.Runtime;
using Jint.Runtime.Interop;

namespace Jint.Native.Number
{
    /// <summary>
    /// http://www.ecma-international.org/ecma-262/5.1/#sec-15.7.4
    /// </summary>
    public sealed class NumberPrototype : NumberInstance
    {
        private NumberPrototype(Engine engine)
            : base(engine)
        {
        }

        public static NumberPrototype CreatePrototypeObject(Engine engine, NumberConstructor numberConstructor)
        {
            var obj = new NumberPrototype(engine);
            obj.Prototype = engine.Object.PrototypeObject;
            obj.PrimitiveValue = 0;

            obj.FastAddProperty("constructor", numberConstructor, false, false, false);

            return obj;
        }

        public void Configure()
        {
            FastAddProperty("toString", new ClrFunctionInstance<object, object>(Engine, ToNumberString), false, false, false);
            FastAddProperty("toLocaleString", new ClrFunctionInstance<object, object>(Engine, ToLocaleString), false, false, false);
            FastAddProperty("valueOf", new ClrFunctionInstance<object, object>(Engine, ValueOf), false, false, false);
            FastAddProperty("toFixed", new ClrFunctionInstance<object, object>(Engine, ToFixed), false, false, false);
            FastAddProperty("toExponential", new ClrFunctionInstance<object, object>(Engine, ToExponential), false, false, false);
            FastAddProperty("toPrecision", new ClrFunctionInstance<object, object>(Engine, ToPrecision), false, false, false);
        }

        private object ToLocaleString(object arg1, object[] arg2)
        {
            throw new System.NotImplementedException();
        }

        private object ValueOf(object arg1, object[] arg2)
        {
            throw new System.NotImplementedException();
        }

        private object ToFixed(object arg1, object[] arg2)
        {
            throw new System.NotImplementedException();
        }

        private object ToExponential(object arg1, object[] arg2)
        {
            throw new System.NotImplementedException();
        }

        private object ToPrecision(object arg1, object[] arg2)
        {
            throw new System.NotImplementedException();
        }

        private static object ToNumberString(object thisObject, object[] arguments)
        {
            return TypeConverter.ToString(thisObject);
        }

    }
}
