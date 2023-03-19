using Microsoft.Msagl.Drawing;


namespace VertexCoverWinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private MyGraph graph = new MyGraph();

        private bool CheckCorectInput(string str)
        {
            str = str.Replace("\r", "");

            if (str.Length == 0)
            {
                MessageBox.Show("�� ����� �� �����!");
                return false;
            }

            foreach (char elem in str)//������� �� ���� ��������
            {
                if (!Char.IsDigit(elem) && elem != ':' && elem != ' ' && elem != '\n')
                {
                    MessageBox.Show("������� �����!\n�������� ���� �������.");
                    return false;
                }
            }

            string[] paragraph = str.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < paragraph.Length; i++)
            {
                if (!paragraph[i].Contains(':'))
                {
                    MessageBox.Show("������� �����!\nϳ��� ������ ������� ������� ��� ���������.");
                    return false;
                }
            }

            if (paragraph.Length < 2)//�������� �� ����
            {
                MessageBox.Show("������� �����!\n���� ������� ���� �� ��� ����� ������.");
                return false;
            }

            int[] numbers = new int[paragraph.Length];

            for (int i = 0; i < paragraph.Length; i++)//�������� �� ��������������
            {
                int temp = Convert.ToInt32(paragraph[i].Substring(0, paragraph[i].IndexOf(':')));

                if (i == 0)
                {
                    if (temp != 1)
                    {
                        MessageBox.Show("������� �����!\n������ ������ ������ ���������� � 1.");
                        return false;
                    }

                }
                else
                {
                    if (numbers[i - 1] != temp - 1)
                    {
                        MessageBox.Show("������� �����!\n������ ������ ������ ���� � ������� ���������.");
                        return false;
                    }
                }

                numbers[i] = temp;
            }

            for (int i = 0; i < paragraph.Length; i++)//�������� ������ �� ���������
            {
                string[] temp = paragraph[i].Substring(paragraph[i].IndexOf(':') + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);//��������� ������ ������

                foreach (string elem in temp)
                {
                    bool chek = false;

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] == Convert.ToInt32(elem))
                        {
                            chek = true;
                        }
                    }

                    if (!chek)
                    {
                        MessageBox.Show("������� �����!\n����� ������� ������� ���� �������� ����� ����������.");
                        return false;
                    }
                }
            }

            return true;
        }


        private void GreedyButton_Click(object sender, EventArgs e)
        {
            foreach (var eg in GraphVisualBox.Graph.Edges)
            {
                eg.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
            foreach (var nd in GraphVisualBox.Graph.Nodes)
            {
                nd.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
            GraphVisualBox.Refresh();

            List<Vertex> temp = graph.VertexCover_Greedy();
            string result = "{";
            for (int i = 0; i < temp.Count; i++)
            {
                if (i == temp.Count - 1)
                {
                    result = result + temp[i].Number.ToString() + "}";
                }
                else
                {
                    result = result + temp[i].Number.ToString() + ", ";
                }
            }

            for (int i = 0; i < temp.Count; i++)
            {
                Thread.Sleep(500);
                foreach (var eg in GraphVisualBox.Graph.Edges)
                {
                    if (eg.TargetNode.Id == temp[i].Number.ToString() || eg.SourceNode.Id == temp[i].Number.ToString())
                    {
                        eg.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }

                foreach (var nd in GraphVisualBox.Graph.Nodes)
                {
                    if (nd.Id == temp[i].Number.ToString())
                    {
                        nd.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }
                GraphVisualBox.Refresh();
            }

            GreedyIterations.Text = graph.Iteration.ToString();
            GreedyResult.Text = result;
        }

        private void ApproxButton_Click(object sender, EventArgs e)
        {
            foreach (var eg in GraphVisualBox.Graph.Edges)
            {
                eg.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
            foreach (var nd in GraphVisualBox.Graph.Nodes)
            {
                nd.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
            GraphVisualBox.Refresh();

            List<Vertex> temp = graph.VertexCover_Approx();
            string result = "{";
            for (int i = 0; i < temp.Count; i++)
            {
                if (i == temp.Count - 1)
                {
                    result = result + temp[i].Number.ToString() + "}";
                }
                else
                {
                    result = result + temp[i].Number.ToString() + ", ";
                }
            }

            for (int i = 0; i < temp.Count; i++)
            {
                if (i%2 == 0)
                {
                    Thread.Sleep(500);
                }
                foreach (var eg in GraphVisualBox.Graph.Edges)
                {
                    if (eg.TargetNode.Id == temp[i].Number.ToString() || eg.SourceNode.Id == temp[i].Number.ToString())
                    {
                        eg.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }

                foreach (var nd in GraphVisualBox.Graph.Nodes)
                {
                    if (nd.Id == temp[i].Number.ToString())
                    {
                        nd.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }
                GraphVisualBox.Refresh();
            }


            ApproxIterations.Text = graph.Iteration.ToString();
            ApproxResult.Text = result;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CheckCorectInput(VertexList.Text))
            {
                graph = new MyGraph(VertexList.Text);
                GraphVisualize();
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string pathRes = "Result.txt";
            string result = "";
            if (GreedyResult.Text.Length != 0)
            {
                result += "Greedy result " + GreedyResult.Text + "\n";
            }
            if (ApproxResult.Text.Length != 0)
            {
                result += "Approx result " + ApproxResult.Text + "\n";
            }
            if (result.Length == 0)
            {
                MessageBox.Show("���� ����������, �� ����� ��������");
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(pathRes, false))
                {
                    await wr.WriteLineAsync(result);
                }
                MessageBox.Show("���������� ���������!");
            }
        }

        private void GraphVisualize()
        {
            Microsoft.Msagl.Drawing.Graph graphVis = new Microsoft.Msagl.Drawing.Graph();

            List<Vertex> temp_V = graph.Vertices;
            List<Edge> temp_E = graph.Edges;

            for (int i = 0; i < temp_V.Count; i++)
            {
                graphVis.AddNode(temp_V[i].Number.ToString());
            }

            for (int i = 0; i < temp_E.Count; i++)
            {

                graphVis.AddEdge(temp_E[i].FromVert.Number.ToString(), temp_E[i].ToVert.Number.ToString()).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None; 
            }



            GraphVisualBox.Graph = graphVis;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            string text;
            using (StreamReader read = new StreamReader("Umova.txt"))
            {
                text = read.ReadToEnd();
            }
            if (CheckCorectInput(text))
            {
                VertexList.Text = text;
            }
        }

        private async void SaveUmova_Click(object sender, EventArgs e)
        {
            string text = VertexList.Text;
            using (StreamWriter write = new StreamWriter("Umova.txt", false))
            {
                await write.WriteLineAsync(text);
            }

            MessageBox.Show("����� ���������");
        }
    }
}