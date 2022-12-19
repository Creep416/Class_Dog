namespace Class_Dog
{
    public partial class Form1 : Form
    {
        Dog barbos = new Dog("Barbos");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            barbos.Dog_gav(a.GetManifestResourceStream("Dog.dog.wav"));
        }
    }
}