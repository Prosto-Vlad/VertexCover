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
                MessageBox.Show("Ви нічого не ввели!");
                return false;
            }

            foreach (char elem in str)//первірка на лишні елементи
            {
                if (!Char.IsDigit(elem) && elem != ':' && elem != ' ' && elem != '\n')
                {
                    MessageBox.Show("Помилка ввода!\nПриберіть зайві символи.");
                    return false;
                }
            }

            string[] paragraph = str.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < paragraph.Length; i++)
            {
                if (!paragraph[i].Contains(':'))
                {
                    MessageBox.Show("Помилка ввода!\nПісля номеру вершини повинно йти двокрапка.");
                    return false;
                }
            }

            if (paragraph.Length < 2)//перевірка на розір
            {
                MessageBox.Show("Помилка ввода!\nГраф повинен мати дві або більше вершин.");
                return false;
            }

            int[] numbers = new int[paragraph.Length];

            for (int i = 0; i < paragraph.Length; i++)//перевірка на впорядкованість
            {
                int temp = Convert.ToInt32(paragraph[i].Substring(0, paragraph[i].IndexOf(':')));

                if (i == 0)
                {
                    if (temp != 1)
                    {
                        MessageBox.Show("Помилка ввода!\nНомери графів повинні починатись з 1.");
                        return false;
                    }

                }
                else
                {
                    if (numbers[i - 1] != temp - 1)
                    {
                        MessageBox.Show("Помилка ввода!\nНомери графів повинні бути у порядку зростання.");
                        return false;
                    }
                }

                numbers[i] = temp;
            }

            for (int i = 0; i < paragraph.Length; i++)//перевірка вершин на існування
            {
                string[] temp = paragraph[i].Substring(paragraph[i].IndexOf(':') + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);//створення маству вершин

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
                        MessageBox.Show("Помилка ввода!\nКожна вершина повинна бути записана перед двокрапкою.");
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
                MessageBox.Show("Немає результатів, які можна зберегти");
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(pathRes, false))
                {
                    await wr.WriteLineAsync(result);
                }
                MessageBox.Show("Результати збережено!");
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

            MessageBox.Show("Умова збережена");
        }
    }
}