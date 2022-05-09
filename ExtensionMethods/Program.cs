using ExtensionMethods;

var abc = "ABC";

abc.Debug(); // instead of doing console.writeline, we createed a method on the other page as a quick way to do this

var str = "abcdefg";

str.Ucase();

var i = 5;

5.Fn1().ToString().Debug(); // Fn1 was a math method, need to use ToString to convert int to string and then use .Debug() method to write out the answer