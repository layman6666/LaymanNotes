// E-科学计数法表示
(25000).ToString("E"); // 结果：2.500000E+004

// C-货币表示，带有逗号分隔符，默认小数点后保留两位，四舍五入
(2.5).ToString("C"); // 结果：￥2.50

// D[length]-十进制数
(25).ToString("D5"); // 结果：00025

// F[precision]-浮点数，保留小数位数(四舍五入)
(25).ToString("F2"); // 结果：25.00

// G[digits]-常规，保留指定位数的有效数字，四舍五入
(2.52).ToString("G2"); // 结果：2.5

// N-带有逗号分隔符，默认小数点后保留两位，四舍五入
(2500000).ToString("N"); // 结果：2,500,000.00

// X-十六进制，非整型将产生格式异常 X4 表示4个字节 x2 小写
(255).ToString("X"); // 结果：FF
ToString 也可以自定义补零格式化：

(15).ToString("000");              // 结果：015
(15).ToString("value is 0");       // 结果：value is 15
(10.456).ToString("0.00");         // 结果：10.46
(10.456).ToString("00");           // 结果：10
(10.456).ToString("value is 0.0"); // 结果：value is 10.5

转换为二进制、八进制、十六进制输出：
int number = 15;
Convert.ToString(number, 2);  // 结果：1111
Convert.ToString(number, 8);  // 结果：17
Convert.ToString(number, 16); // 结果：f


C# 日期时间格式
DateTime dt = DateTime.Now;
dt.ToString();//2021/10/26 23:23:51 
dt.ToString("yyyy-MM-dd HH:mm:ss fff");//2021-10-26 23:22:19 179
