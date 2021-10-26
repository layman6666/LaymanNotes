// E-��ѧ��������ʾ
(25000).ToString("E"); // �����2.500000E+004

// C-���ұ�ʾ�����ж��ŷָ�����Ĭ��С���������λ����������
(2.5).ToString("C"); // �������2.50

// D[length]-ʮ������
(25).ToString("D5"); // �����00025

// F[precision]-������������С��λ��(��������)
(25).ToString("F2"); // �����25.00

// G[digits]-���棬����ָ��λ������Ч���֣���������
(2.52).ToString("G2"); // �����2.5

// N-���ж��ŷָ�����Ĭ��С���������λ����������
(2500000).ToString("N"); // �����2,500,000.00

// X-ʮ�����ƣ������ͽ�������ʽ�쳣 X4 ��ʾ4���ֽ� x2 Сд
(255).ToString("X"); // �����FF
ToString Ҳ�����Զ��岹���ʽ����

(15).ToString("000");              // �����015
(15).ToString("value is 0");       // �����value is 15
(10.456).ToString("0.00");         // �����10.46
(10.456).ToString("00");           // �����10
(10.456).ToString("value is 0.0"); // �����value is 10.5

ת��Ϊ�����ơ��˽��ơ�ʮ�����������
int number = 15;
Convert.ToString(number, 2);  // �����1111
Convert.ToString(number, 8);  // �����17
Convert.ToString(number, 16); // �����f


C# ����ʱ���ʽ
DateTime dt = DateTime.Now;
dt.ToString();//2021/10/26 23:23:51 
dt.ToString("yyyy-MM-dd HH:mm:ss fff");//2021-10-26 23:22:19 179
