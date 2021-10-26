#Winform 异步方法不卡UI线程

private async void button1_Click(object sender, EventArgs e)
{
    var t = Task.Run(() =>
    {
        Thread.Sleep(5000); #模拟耗时操作
        return "Hello Async Function"; #返回值
    });

    textBox1.Text = await t; #await 取出 Task<string> 中的string
}