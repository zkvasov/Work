using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using RandomForFigures;

namespace FiguresRunning
{
    [Serializable]
    public partial class FiguresRunning : Form
    {
        //list of all figures
        List<Figure> allFigures = new List<Figure>();
        int countFigure = 0;

        RandomHelper rand = new RandomHelper();
        private object lockFigures = new object();

        public FiguresRunning()
        {

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
        }


        private Point GetMaxPointField()                              
        {
            return new Point(this.pictureBoxMain.Width - 1, this.pictureBoxMain.Height - 1);
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            Point Pmax = GetMaxPointField();
            foreach (Figure f in allFigures)
            {
                try
                {
                    f.Move(Pmax);
                }
                catch(OutOfFieldException ex)
                {
                    f.ReturnToField(Pmax);
                    LogHelper.WriteLog(String.Format("{0} Figure: {1}; Coordinates: {2}", ex.Message, ex.Figure, ex.Point));
                }

                f.Draw(e.Graphics);
            }
            Invalidate();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Point Pmax = GetMaxPointField();
            Point pos = rand.GetRandomPosition(Pmax);
            this.allFigures.Add(new Triangle(pos.X, pos.Y, rand));
            countFigure++;
            this.treeViewFigures.Nodes.Add(CreateFigureNode());   //add node figure
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Point Pmax = GetMaxPointField();
            Point pos = rand.GetRandomPosition(Pmax);
            this.allFigures.Add(new Rect(pos.X, pos.Y, rand));
            countFigure++;
            this.treeViewFigures.Nodes.Add(CreateFigureNode());   //add node figure
        }
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Point Pmax = GetMaxPointField();
            Point pos = rand.GetRandomPosition(Pmax);
            this.allFigures.Add(new Circle(pos.X, pos.Y, rand));
            countFigure++;
            this.treeViewFigures.Nodes.Add(CreateFigureNode());   //add node figure
        }
        
        public TreeNode CreateFigureNode()
        {
            TreeNode figureNode = new TreeNode(allFigures[countFigure - 1].Name + countFigure.ToString())
            {
                Tag = allFigures[countFigure - 1]
            };
            return figureNode;
        }

        int duration = 0;
        private void timerMain_Tick(object sender, EventArgs e)
        {
            duration++;
            this.textBoxTimer.Text = duration.ToString();

            this.pictureBoxMain.Refresh();
            //Point Pmax = GetMaxPointField();
            //foreach (Figure f in allFigures)
            //{
            //    f.Move(Pmax);
            //}
           // Invalidate();
            
        }


        private void btStopGoFigure_Click(object sender, EventArgs e)             
        {
            if (this.treeViewFigures.SelectedNode != null)
                foreach (Figure fig in allFigures)
                {
                    if (this.treeViewFigures.SelectedNode.Tag.Equals(fig))
                    {
                        if (fig.isNotMoved)
                        {
                            fig.StopMoving();
                            fig.isNotMoved = false;
                            btStopGoFigure.Text = MyStrings.Go;
                        }
                        else
                        {
                            fig.ReturnMoving();
                            fig.isNotMoved = true;
                            btStopGoFigure.Text = MyStrings.Stop;
                        }
                    }
                }
        }

        private void treeViewFigures_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (Figure fig in allFigures)
            {
                if (e.Node.Tag.Equals(fig))
                {
                    if (fig.isNotMoved)
                    {
                        btStopGoFigure.Text = MyStrings.Stop;
                    }
                    else
                    {
                        btStopGoFigure.Text = MyStrings.Go;
                    }
                }
            }
        }

        private void FiguresRunning_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                System.Globalization.CultureInfo.GetCultureInfo("ru-UA")
            };
            comboBoxLanguage.DisplayMember = "NativeName";
            comboBoxLanguage.ValueMember = "Name";

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBoxLanguage.SelectedValue = Properties.Settings.Default.Language;
            }

        }

        private void FiguresRunning_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Language = comboBoxLanguage.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)          
        {
            switch (comboBoxLanguage.SelectedIndex)
            {
                case 0:
                    LocalizationHelper.ApplyCulture("en-US");
                    break;
                case 1:
                    LocalizationHelper.ApplyCulture("ru-UA");
                    break;
            }
        }

        //Serialization in 3 formats
        private void saveInBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "figures file (*.bin)|*.bin|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "My figures"
            };
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, allFigures);
                }
            }
        }
        private void openbinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "figures file (*.bin)|*.bin|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "My figures"
            };
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                allFigures.Clear();
                treeViewFigures.Nodes.Clear();
                countFigure = 0;

                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    allFigures = (List<Figure>)formatter.Deserialize(fs);
                }

                for (int i = 0; i < allFigures.Count; i++)
                {
                    countFigure++;
                    treeViewFigures.Nodes.Add(CreateFigureNode());
                }

                pictureBoxMain.Update();
                

            }
        }

        private void saveInxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "figures file (*.xml)|*.xml|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "My figures"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serialaizer = new XmlSerializer(typeof(List<Figure>));
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    serialaizer.Serialize(fs, allFigures);
                }
            }
        }
        private void openxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogXML = new OpenFileDialog()
            {
                Filter = "figures file (*.xml)|*.xml|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "FiguresSave"
            };
            
            if (openFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                allFigures.Clear();
                treeViewFigures.Nodes.Clear();
                countFigure = 0;

                XmlSerializer deserialaizer = new XmlSerializer(typeof(List<Figure>));
                using (FileStream fs = new FileStream(openFileDialogXML.FileName, FileMode.OpenOrCreate))
                {
                    allFigures = (List<Figure>)deserialaizer.Deserialize(fs);
                }
                    
                for (int i = 0; i < allFigures.Count; i++)
                {
                    countFigure++;
                    treeViewFigures.Nodes.Add(CreateFigureNode());
                }

                pictureBoxMain.Update();
            }
        }

        private void saveJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "figures file (*.json)|*.json|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "My figures"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Figure>));
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, allFigures);
                }
            }
        }
        private void openjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "figures file (*.json)|*.json|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "My figures"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                allFigures.Clear();
                treeViewFigures.Nodes.Clear();
                countFigure = 0;

                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Figure>));
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    allFigures = (List<Figure>)jsonFormatter.ReadObject(fs);
                }

                for (int i = 0; i < allFigures.Count; i++)
                {
                    countFigure++;
                    treeViewFigures.Nodes.Add(CreateFigureNode());
                }

                pictureBoxMain.Update();
            }
        }

        //
        private void BumpFigures(object sender, MoveEventArgs args)
        {
            Figure figure = (Figure)sender;
            string name = figure.Name;
            if(name == MyStrings.Circle)
            {
                CheckCircle(figure, args);
            }
            else if (name == MyStrings.Rectangle)
            {
                CheckRectangle(figure, args);
            }
            else
            {
                CheckTriangle(figure, args);
            }


            
        }

        private void CheckCircle(Figure currFigure, MoveEventArgs args)
        {
            Circle circle = (Circle)currFigure;
            foreach (Figure fig in allFigures.Where(f=>f.Name == MyStrings.Circle && f.ID!=currFigure.ID))
            {
                //расстояние между фигурами
                double distance = Math.Sqrt((currFigure.PosX - fig.PosX) * (currFigure.PosX - fig.PosX)     
                    + (currFigure.PosY - fig.PosY) * (currFigure.PosY - fig.PosY));
                if (distance <= circle.Diametr)
                {
                    System.Media.SystemSounds.Beep.Play();  //play sound
                    labelX.Text = args.BumpPoint.X.ToString();
                    labelY.Text = args.BumpPoint.Y.ToString();
                    //labelX.Text = circle.PosX.ToString();
                    //labelY.Text = circle.PosY.ToString();

                    // beepList.Add(fig.ID);
                }
            }
        }

        private void CheckRectangle(Figure currFigure, MoveEventArgs args)
        {

            Rect rect = (Rect)currFigure;
            foreach (Figure fig in allFigures.Where(f => f.Name == MyStrings.Rectangle && f.ID != currFigure.ID))
            {
                //расстояние между фигурами
                double distance = Math.Sqrt((currFigure.PosX - fig.PosX) * (currFigure.PosX - fig.PosX)    
                    + (currFigure.PosY - fig.PosY) * (currFigure.PosY - fig.PosY));
                if (distance <= Math.Sqrt(rect.Width * rect.Width + rect.Height * rect.Height))      //сравнение с диагональю                             
                {
                    System.Media.SystemSounds.Beep.Play();  //play sound
                    labelX.Text = args.BumpPoint.X.ToString();
                    labelY.Text = args.BumpPoint.Y.ToString();
                    //labelX.Text = rect.PosX.ToString();
                    //labelY.Text = rect.PosY.ToString();

                    // beepList.Add(fig.ID);
                }
            }
        }

        private void CheckTriangle(Figure currFigure, MoveEventArgs args)
        {

            Triangle triangle = (Triangle)currFigure;

            foreach (Figure fig in allFigures.Where(f => f.Name == MyStrings.Triangle && f.ID != currFigure.ID))
            {
                //расстояние между фигурами
                double distance = Math.Sqrt((currFigure.PosX - fig.PosX) * (currFigure.PosX - fig.PosX)     //расстояние между фигурами
                    + (currFigure.PosY - fig.PosY) * (currFigure.PosY - fig.PosY));
                if (distance <= Math.Sqrt(triangle.Width * triangle.Width + triangle.Height * triangle.Height))               //сравнение с диагональю
                {
                    System.Media.SystemSounds.Beep.Play();  //play sound
                    labelX.Text = args.BumpPoint.X.ToString();
                    labelY.Text = args.BumpPoint.Y.ToString();
                    //labelX.Text = triangle.PosX.ToString();
                    //labelY.Text = triangle.PosY.ToString();

                    // beepList.Add(fig.ID);
                }
            }
            
            
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            foreach (Figure fig in allFigures)
            {
                if (this.treeViewFigures.SelectedNode.Tag.Equals(fig))
                {
                    fig.OnMove += BumpFigures;
                }
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            foreach (Figure fig in allFigures)
            {
                if (this.treeViewFigures.SelectedNode.Tag.Equals(fig))
                {
                    fig.OnMove -= BumpFigures;
                }
            }
        }
    }
}
