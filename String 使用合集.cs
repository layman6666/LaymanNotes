逐字字符串（Verbatim Strings）字符将被编程器按照原义进行解释。
使用逐字字符串只需在字符串前面加上 @ 符号。
// 逐字字符串：转义符
var filename = @"c:\temp\newfile.txt";
Console.WriteLine(filenaame);


数字格式化转换
string.Format("{index[:format]}", number)
    
可使用“0”和“#”占位符进行补位。“0” 表示位数不够位数就补充“0”，小数部分如果位数多了则会四舍五入；“#”表示占位，用于辅助“0”进行补位
// “0”描述：占位符，如果可能，填充位
string.Format("{0:000000}", 1234); // 结果：001234

// “#”描述：占位符，如果可能，填充位
string.Format("{0:######}", 1234);  // 结果：1234
string.Format("{0:#0####}", 1234);  // 结果：01234
string.Format("{0:0#0####}", 1234); // 结果：0001234

// "."描述：小数点
string.Format("{0:000.000}", 1234);       // 结果：1234.000
string.Format("{0:000.000}", 4321.12543); // 结果：4321.125

// ","描述：千分表示
string.Format("{0:0,0}", 1234567);   //结果：1,234,567

// "%"描述：格式化为百分数
string.Format("{0:0%}", 1234);        // 结果：123400%
string.Format("{0:#%}", 1234.125);   // 结果：123413%
string.Format("{0:0.00%}", 1234);     // 结果：123400.00%
string.Format("{0:#.00%}", 1234.125); // 结果：123412.50%


字符串拼接
var parts = new[] { "Foo", "Bar", "Fizz", "Buzz" };
var joined = string.Join(", ", parts);
// joined = "Foo, Bar, Fizz, Buzz"

string first = "Hello";
stringsecond = "World";
string foo = first + " " + second;
string foo = string.Concat(first, " ", second);
string foo = string.Format("{0} {1}", firstname, lastname);
string foo = $"{firstname} {lastname}";


字符串内插法
简单用法：

var name = "World";
var str = $"Hello, {name}!";
// str = "Hello, World!"
带日期格式化：

var date = DateTime.Now;
var str = $"Today is {date:yyyy-MM-dd}！";
补齐格式化（Padding）：

var number = 42;

// 向左补齐
var str = $"The answer to life, the universe and everything is {number,5}.";
// str = "The answer to life, the universe and everything is ___42." ('_'表示空格)

// 向右补齐
var str = $"The answer to life, the universe and everything is ${number,-5}.";
// str = "The answer to life, the universe and everything is 42___."
结合内置快捷字母格式化：

var amount = 2.5;
var str = $"It costs {amount:C}";
// str = "￥2.50"

var number = 42;
var str = $"The answer to life, the universe and everything is {number,5:f1}.";
// str = "The answer to life, the universe and everything is ___42.1"
