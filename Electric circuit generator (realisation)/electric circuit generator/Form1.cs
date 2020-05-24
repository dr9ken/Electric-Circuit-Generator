using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electric_circuit_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InputField_CreateList();
            InputField_IndentSettings();
        }

        /////////////////////// INPUT FIELDS ///////////////////////
        List<RichTextBox> InputField = new List<RichTextBox>();
        private void InputField_CreateList()
        {
            InputField.Add(ToR);
            InputField.Add(ToC);
            InputField.Add(ToL);
            InputField.Add(ToS);

            InputField.Add(FromR);
            InputField.Add(FromC);
            InputField.Add(FromL);
            InputField.Add(FromS);

            InputField.Add(NumberR);
            InputField.Add(NumberC);
            InputField.Add(NumberL);
        }
        private void InputField_IndentSettings()
        {
            foreach (RichTextBox field in InputField)
                field.SelectionIndent = 4;
        }
        private void InputDigit(KeyPressEventArgs KeyPressEvent)
        {
            if (Char.IsDigit(KeyPressEvent.KeyChar))
                KeyPressEvent.Handled = false;
            else KeyPressEvent.Handled = true;
        }
        private void ToR_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void ToL_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void ToC_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void ToS_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void FromR_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void FromL_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void fromC_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void FromS_Pressed(object sender, KeyPressEventArgs KeyPressEvent)
        {
            InputDigit(KeyPressEvent);
        }
        private void SourcesBox_TextUpdate(object sender, EventArgs e)
        {
            if (!SourcesBox.Items.Contains(SourcesBox.Text))
                SourcesBox.Text = "sources";
        }

        ////////////////////////// BUTTONS /////////////////////////
        OpenFileDialog FileForSave = new OpenFileDialog();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileForSave.ShowDialog();
            GenerateButton.Enabled = true;
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SourcesBox.Enabled = true;
            SaveButton.Enabled = true;
            GenerateButton.Enabled = true;
            foreach (RichTextBox filed in InputField) filed.Enabled = true;

            RefreshButton.Enabled = false;
            //Bitmap SetImage = new Bitmap(PictureBox_Image("NO"));
            Bitmap SetImage = new Bitmap(Properties.Resources.no);
            PictureBox.Image = (Image)SetImage;
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SourcesBox.Enabled = false;
            SaveButton.Enabled = false;
            GenerateButton.Enabled = false;

            foreach (RichTextBox field in InputField)
            {
                if (field.Text == "") field.Text = "0";
                field.Enabled = false;
            }

            CircuitGeneration();

            RefreshButton.Enabled = true;
            Bitmap SetImage = new Bitmap(Properties.Resources.yes);
            PictureBox.Image = (Image)SetImage;
        }

        //////////////////////// GENERATION ////////////////////////
        Random Rnd = new Random();
        private void CircuitGeneration()
        {
            int NumbR = Convert.ToInt32(NumberR.Text);
            int NumbL = Convert.ToInt32(NumberL.Text);
            int NumbC = Convert.ToInt32(NumberC.Text);

            List<Wire> wires = Placement.distribution(NumbR + NumbL + NumbC);
            Circuit[] circuit = Placement.completion(wires, NumbR, NumbL, NumbC, SourcesBox.Text);
            WriteToFile(circuit);
        }
        private void WriteToFile(Circuit[] Circuit)
        {
            Random rnd = new Random();
            FileStream SaveFile = new FileStream(FileForSave.FileName, FileMode.Append);
            StreamWriter Writer = new StreamWriter(SaveFile);

            int ElementNumber = 0;
            foreach (Circuit Wire in Circuit)
            {
                string Knots = Wire.get_firstKnot() + Wire.get_secondKnot();
                string[] Elements = Wire.get_elements().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string Element in Elements)
                {
                    ElementNumber++;
                    Writer.WriteLine($"{ElementNumber.ToString() + Knots} - " +
                        $"{Element}={Get_ElementValue(Element).ToString()}");
                }
            }
            Writer.WriteLine(">---> END <---<\n");
            Writer.Close();
            SaveFile.Close();
        }
        private int Get_ElementValue(string Element)
        {
            switch (Element)
            {
                case "R":
                    int toR = Convert.ToInt32(ToR.Text);
                    int fromR = Convert.ToInt32(FromR.Text);
                    return Rnd.Next(Min(fromR, toR), Max(fromR, toR) + 1);
                case "L":
                    int toL = Convert.ToInt32(ToL.Text);
                    int fromL = Convert.ToInt32(FromL.Text);
                    return Rnd.Next(Min(fromL, toL), Max(fromL, toL) + 1);
                case "C":
                    int toC = Convert.ToInt32(ToC.Text);
                    int fromC = Convert.ToInt32(FromC.Text);
                    return Rnd.Next(Min(fromC, toC), Max(fromC, toC) + 1);
                default:
                    int toS = Convert.ToInt32(ToS.Text);
                    int fromS = Convert.ToInt32(FromS.Text);
                    return Rnd.Next(Min(fromS, toS), Max(fromS, toS) + 1);
            }
        }
        private int Min(int x, int y)
        {
            if (x <= y) return x; else return y;
        }
        private int Max(int x, int y)
        {
            if (x >= y) return x; else return y;
        }
    }
}

public class Wire
{
    public void push_info(int one, int two, int number)
    {
        knotOne = one;
        knotTwo = two;
        numberElem = number;
    }
    public int get_firstKnot()
    {
        return knotOne;
    }
    public int get_secondKnot()
    {
        return knotTwo;
    }
    public int get_number()
    {
        return numberElem;
    }

    int knotOne;
    int knotTwo;
    int numberElem;
}

public class Circuit
{
    public void push_info(int one, int two, string elem)
    {
        knotOne = one.ToString();
        knotTwo = two.ToString();
        elements = elem;
    }
    public string get_firstKnot()
    {
        return knotOne;
    }
    public string get_secondKnot()
    {
        return knotTwo;
    }
    public string get_elements()
    {
        return elements;
    }

    string knotOne;
    string knotTwo;
    string elements;
}

public class Placement
{
    public static List<Wire> distribution(int numberElements)
    {
        int knotOne = 1, knotTwo = 2; // knots
        bool division = false; // FALSE - verical, TRUE - horizontal
        List<Wire> wires = new List<Wire>(); // list of wires

        while (numberElements != 0)
        {
            if (division)
            {
                horizontal_wire(ref wires, ref knotOne, ref knotTwo, ref numberElements);
                division = !division;
                continue;
            }

            if (!division)
            {
                vertical_wire(ref wires, ref knotOne, ref knotTwo, ref numberElements);
                division = !division;
                continue;
            }
        }

        return wires;
    }
    public static Circuit[] completion(List<Wire> wires, int R, int L, int C, string S)
    {
        List<string> elements = new List<string>();

        elem_in_list(ref elements, "R", R);
        elem_in_list(ref elements, "L", L);
        elem_in_list(ref elements, "C", C);
        list_mixing(ref elements);

        return create_circuit(elements, wires, S);
    }

    /////////////////////////////////// FOR THE 'DISTRIBUTION'///////////////////////////////////
    private static Random Rnd = new Random();
    static void vertical_wire(ref List<Wire> wires, ref int knotOne, ref int knotTwo, ref int numberElements)
    {
        create_verticalWire(ref wires, knotOne, knotTwo, ref numberElements);
        knotOne += 2; knotTwo += 2;
    }
    static void horizontal_wire(ref List<Wire> wires, ref int knotOne, ref int knotTwo, ref int numberElements)
    {
        create_horizontalWire(ref wires, knotOne - 2, knotOne, ref numberElements);
        if (numberElements != 0) create_horizontalWire(ref wires, knotTwo - 2, knotTwo, ref numberElements);
    }
    static void create_verticalWire(ref List<Wire> wires, int knotOne, int knotTwo, ref int numberElements)
    {
        Wire wire = new Wire();

        int number = 0;
        if (numberElements > 1) number = Rnd.Next(1, 3); // number of first wire elements 
        else number = 1;
        numberElements -= number; 

        if (numberElements != 0) wire.push_info(knotOne, knotTwo, number);
        else wire.push_info(knotOne, knotTwo, number);

        wires.Add(wire);
    }
    static void create_horizontalWire(ref List<Wire> wires, int knotOne, int knotTwo, ref int numberElements)
    {
        Wire wire = new Wire();

        int number = 0;
        if (numberElements > 2) number = Rnd.Next(0, 4); // number of first wire elements 
        else if (numberElements > 1) number = Rnd.Next(0, 3);
        else number = Rnd.Next(0, 2);
        numberElements -= number;
        if (knotOne % 2 == 1)
        {
            if (numberElements != 0) wire.push_info(knotOne, knotTwo, number);
            else wire.push_info(knotOne, knotOne + 1, number);

            wires.Add(wire);
            return;
        }

        if (knotOne % 2 == 0)
        {
            if (numberElements != 0) wire.push_info(knotOne, knotTwo, number);
            else
            {
                Wire topWire = wires[wires.Count - 1];
                wires.RemoveAt(wires.Count - 1);

                int sumNumber = topWire.get_number() + number;

                wire.push_info(knotOne - 1, knotOne, sumNumber);
            }

            wires.Add(wire);
            return;
        }

        wires.Add(wire);
    }

    //////////////////////////////////// FOR THE 'COMPLETION'////////////////////////////////////
    static void elem_in_list(ref List<string> elemList, string elementName, int numberElement)
    {
        for (int i = 0; i < numberElement; i++) elemList.Add(elementName);
    }
    static void list_mixing(ref List<string> elemList)
    {
        Random rnd = new Random();

        for (int i = elemList.Count - 1; i >= 1; i--)
        {
            int j = rnd.Next(i + 1);

            var temp = elemList[j];
            elemList[j] = elemList[i];
            elemList[i] = temp;
        }
    }
    static Circuit[] create_circuit(List<string> elements, List<Wire> wires, string S)
    {
        Circuit[] circuit = new Circuit[wires.Count];
        string elementsWires = S + " ";

        int wireNum = 0;
        foreach (Wire wire in wires)
        {
            for (int i = 0; i < wire.get_number(); i++)
            {
                elementsWires += elements[0] + " ";
                elements.RemoveAt(0);
            }

            Circuit temp = new Circuit();
            temp.push_info(wire.get_firstKnot(), wire.get_secondKnot(), elementsWires);

            circuit[wireNum] = temp;
            wireNum++;
            elementsWires = "";
        }

        return circuit;
    }
}
