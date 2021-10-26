�����ַ�����Verbatim Strings���ַ��������������ԭ����н��͡�
ʹ�������ַ���ֻ�����ַ���ǰ����� @ ���š�
// �����ַ�����ת���
var filename = @"c:\temp\newfile.txt";
Console.WriteLine(filenaame);


���ָ�ʽ��ת��
string.Format("{index[:format]}", number)
    
��ʹ�á�0���͡�#��ռλ�����в�λ����0�� ��ʾλ������λ���Ͳ��䡰0����С���������λ����������������룻��#����ʾռλ�����ڸ�����0�����в�λ
// ��0��������ռλ����������ܣ����λ
string.Format("{0:000000}", 1234); // �����001234

// ��#��������ռλ����������ܣ����λ
string.Format("{0:######}", 1234);  // �����1234
string.Format("{0:#0####}", 1234);  // �����01234
string.Format("{0:0#0####}", 1234); // �����0001234

// "."������С����
string.Format("{0:000.000}", 1234);       // �����1234.000
string.Format("{0:000.000}", 4321.12543); // �����4321.125

// ","������ǧ�ֱ�ʾ
string.Format("{0:0,0}", 1234567);   //�����1,234,567

// "%"��������ʽ��Ϊ�ٷ���
string.Format("{0:0%}", 1234);        // �����123400%
string.Format("{0:#%}", 1234.125);   // �����123413%
string.Format("{0:0.00%}", 1234);     // �����123400.00%
string.Format("{0:#.00%}", 1234.125); // �����123412.50%


�ַ���ƴ��
var parts = new[] { "Foo", "Bar", "Fizz", "Buzz" };
var joined = string.Join(", ", parts);
// joined = "Foo, Bar, Fizz, Buzz"

string first = "Hello";
stringsecond = "World";
string foo = first + " " + second;
string foo = string.Concat(first, " ", second);
string foo = string.Format("{0} {1}", firstname, lastname);
string foo = $"{firstname} {lastname}";


�ַ����ڲ巨
���÷���

var name = "World";
var str = $"Hello, {name}!";
// str = "Hello, World!"
�����ڸ�ʽ����

var date = DateTime.Now;
var str = $"Today is {date:yyyy-MM-dd}��";
�����ʽ����Padding����

var number = 42;

// ������
var str = $"The answer to life, the universe and everything is {number,5}.";
// str = "The answer to life, the universe and everything is ___42." ('_'��ʾ�ո�)

// ���Ҳ���
var str = $"The answer to life, the universe and everything is ${number,-5}.";
// str = "The answer to life, the universe and everything is 42___."
������ÿ����ĸ��ʽ����

var amount = 2.5;
var str = $"It costs {amount:C}";
// str = "��2.50"

var number = 42;
var str = $"The answer to life, the universe and everything is {number,5:f1}.";
// str = "The answer to life, the universe and everything is ___42.1"
