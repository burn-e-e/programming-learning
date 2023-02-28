public class Example
{
     private void printView_Click(object sender, EventArgs e)
     {
          Panel panel = new Panel();
          this.Controls.Add(panel);
          Graphics grp = panel.CreateGraphics();
          Size formSize = this.ClientSize;
          bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
          grp = Graphics.FromImage(bitmap);
          Point panelLocation = PointToScreen(panel.Location);
          grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
          printPreviewDialog1.Document = printDocument1;
          printPreviewDialog1.PrintPreviewControl.Zoom = 1;
          printPreviewDialog1.ShowDialog();
     }
}