namespace MyWinForm
{
    public partial class FormException : Form
    {
        public FormException()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 25;
                //open resources Open
                var result = i / 5;
            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                //close resources Close
                MessageBox.Show("finally");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] array = new string[] { "111", "222" };
                if (array.Length < 10)
                    MessageBox.Show("error");
                else
                    MessageBox.Show(array[10]);

            }
            catch (IndexOutOfRangeException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MyClass my = null;
                if (my != null)
                    my.id = 1;
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string st = "123qwerty";
                int result;
                if (Int32.TryParse(st, out result))
                    MessageBox.Show("ok");
                else
                    MessageBox.Show("error");

                //int i = Int32.Parse(st);
                //i = Convert.ToInt32(st);
            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var st = File.ReadAllText("qweqeqwe");
            }
            catch (FileNotFoundException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // if()
                throw new FormatException("param1 = 123, param2=456");
            }
            catch (FormatException err)
            {
                //insert param1 = 123, param2=456
                MessageBox.Show(err.Message);
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);                
                try
                {
                    File.WriteAllText(@"//adada/adadsa/adad/adad", "");
                }
                catch (Exception)
                {
                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    throw;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //////
                throw new MyException("что то полшло не так");
            }
            catch (MyException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbTest.Text = "Test";
            string st = tbTest.Text;
        }
    }

    class MyClass
    {
        public int id { get; set; }
    }

    public class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}