public class Example
{
     private void printButton_Click(object sender, EventArgs e)
     {
          try
          {
               streamToPrint = new StreamReader("C:\\My Documents\\MyFile.txt");
               try
               {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    pd.Print();
               }
               finally
               {
                    streamToPrint.Close();
               }
          }
          catch (Exception ex)
          {
               MessageBox.Show(ex.Message);
          }
     }
}