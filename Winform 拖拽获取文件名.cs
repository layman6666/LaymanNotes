#1.设置控件如Form  AllowDrop = true


#2.DragDrop事件
private void Form1_DragDrop(object sender, DragEventArgs e)
{
    string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
    MessageBox.Show(path);
}


#3.DragEnter事件
private void Form1_DragEnter(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Link;
    else e.Effect = DragDropEffects.None;
}
