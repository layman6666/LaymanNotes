#Winform �첽��������UI�߳�

private async void button1_Click(object sender, EventArgs e)
{
    var t = Task.Run(() =>
    {
        Thread.Sleep(5000); #ģ���ʱ����
        return "Hello Async Function"; #����ֵ
    });

    textBox1.Text = await t; #await ȡ�� Task<string> �е�string
}