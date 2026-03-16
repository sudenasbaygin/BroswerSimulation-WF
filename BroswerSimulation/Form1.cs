using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BroswerSimulation
{
    public partial class Form1 : Form
    {
        DownloadQueue downloadQueue = new DownloadQueue();
        Stack<string> history = new Stack<string>();
        string currentPage = "Home";

        public Form1()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            string yeniSite = textBox1.Text;

            history.Push(currentPage);
            currentPage = yeniSite;

            Form2 f2 = new Form2(textBox1.Text);
            f2.Text = currentPage;


            
            f2.Show();
            

        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            string file = textBox2.Text;

            downloadQueue.Enqueue(file);

            progressBar1.Value = 0;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30);
            }

            if (!downloadQueue.IsEmpty())
            {
                string doneFile = downloadQueue.Dequeue();
                label5.Text = doneFile + " file downloaded";
                label5.Visible = true;
            }
        }
    
    }
    class Node
    {

        public string Data;
        public Node Next;

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }



    class DownloadQueue
    {
        private Node head;
        private Node tail;
        public void Enqueue(string file)
        {
            Node newNode = new Node(file);

            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                 tail.Next = newNode;
                tail = newNode;
            }
        }

        public string Dequeue()
        {
            if (head == null)
                return null;

            string file = head.Data;
            head = head.Next;

            if (head == null)
                tail = null;

            return file;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }

}
