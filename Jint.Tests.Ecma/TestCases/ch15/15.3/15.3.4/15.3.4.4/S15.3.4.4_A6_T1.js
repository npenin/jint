// Copyright 2009 the Sputnik authors.  All rights reserved.
/**
 * The call method takes one or more arguments, thisArg and (optionally) arg1, arg2 etc, and performs
 * a function call using the [[Call]] property of the object
 *
 * @path ch15/15.3/15.3.4/15.3.4.4/S15.3.4.4_A6_T1.js
 * @description Argunemts of call function is (null,[1])
 */

Function("a1,a2,a3","this.shifted=a1;").call(null,[1]);

//CHECK#1
if (this["shifted"].constructor !== Array) {
  $ERROR('#1: The call method takes one or more arguments, thisArg and (optionally) arg1, arg2 etc, and performs a function call using the [[Call]] property of the object');
}

//CHECK#2
if (this["shifted"].length !== 1) {
  $ERROR('#2: The call method takes one or more arguments, thisArg and (optionally) arg1, arg2 etc, and performs a function call using the [[Call]] property of the object');
}

//CHECK#3
if (this["shifted"][0] !== 1) {
  $ERROR('#3: The call method takes one or more arguments, thisArg and (optionally) arg1, arg2 etc, and performs a function call using the [[Call]] property of the object');
}


