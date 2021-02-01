using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2
{
    public partial class frmItemA : Form
    {
        public frmItemA()
        {
            InitializeComponent();
        }

        private void frmItemA_Load(object sender, EventArgs e)
        {

        }
    }
    
    class Aluno
    { 
        //Atributos
     public string Nome;
     private int Documento;
     public int RegistroMatricula;
     public string Turma;

        //Métodos
        public void Nota()
        {

        }
        public void AssistirAula() { 
        }
        public double Media()
        {
            return 0;
        }


     



    }
}

