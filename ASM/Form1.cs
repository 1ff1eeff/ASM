namespace ASM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMap_Click(object sender, EventArgs e)
        {
            CreateMap createMap = new CreateMap();
            createMap.ShowDialog();
        }

        private void CreateNode_Click(object sender, EventArgs e)
        {
            CreateNode createNode = new CreateNode();
            createNode.ShowDialog();
        }

        private void CreateTest_Click(object sender, EventArgs e)
        {
            CreateTest createTest = new CreateTest();
            createTest.ShowDialog();
        }

        private void GraphAndStat_Click(object sender, EventArgs e)
        {
            GraphAndStat createGraph = new GraphAndStat();
            createGraph.Show();
        }

        private void Indicators_Click(object sender, EventArgs e)
        {
            Indicators createIndicators = new Indicators();
            createIndicators.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}