using System;
using System.Drawing;
using System.Windows.Forms;



namespace arboles
{



    public partial class Form1 : Form
    {

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        int x, y, xf, yf;
        int icola = 0;
        
        bool encontrado = false;
        TextBox[] V = new TextBox[20];//textbox donde se mostraran las vertices
       
        int Lv = 50, Lh = 490;
        int[,] pos = new int[15, 2];
        


        Object sender;
        EventArgs e;
        PaintEventArgs ej;
        public Form1()
        {

            InitializeComponent();
            Form1_Shown(sender, e);
           






        }


        private void button1_Click(Object sender, EventArgs e)
        {


            
            panel1.Controls.Clear();
            panel1.Visible = false;
            panel1.Visible = true;
            Lv = 50;
            Lh = 490;

            if (radioButtonAncho.Checked == true)
            {


                Agregavertices();
            }

            else
            {

                Agregaverticesp();    
            }
        }





        Graphics lineas;

        public void Agregaverticesp()
        {

            string cad = "";

            int[,] pila = new int[16, 5];
            int[,] cpila = new int[16, 5];
            int xa = x = int.Parse(xI.Text);
            int ya = y = int.Parse(yI.Text);
            int inpila = 0;
            int incpila = 0;
            bool rep = false;
            int nivel;
            int padre=0;
            int index = 1;





            pila[0, 0] = x;//3L
            pila[0, 1] = y;//4L
            pila[0, 2] = 0;//nivel
            pila[0, 3] = 0;//padre
            pila[0, 4] = 0;//index

            cpila[0, 0] = 5;
            cpila[0, 1] = 5;


           
            if (xF.Text == "*" && yF.Text == "*")
            {


                xf = int.Parse(xI.Text);
                yf = int.Parse(yI.Text);


            }
            else
            {

                xf = int.Parse(xF.Text);
                yf = int.Parse(yF.Text);

            }


            encontrado = false;
            //while(inpila>-1 && encontrado == false)
            while (inpila>-1)
            {
                
                cpila[incpila, 0] = pila[inpila, 0];
                cpila[incpila, 1] = pila[inpila, 1];
                nivel=cpila[incpila, 2] = pila[inpila, 2];
                cpila[incpila, 3] = pila[inpila, 3];
                padre=cpila[incpila, 4] = pila[inpila, 4];
                

                xa = x = pila[inpila , 0];
                ya = y = pila[inpila , 1];
                
                inpila--;
                incpila++;





                {



                    xa = 3;

                    rep= BuscaVerticesp(cpila,incpila,xa,ya);
                    if (rep == false)
                        rep = BuscaVerticespila(pila, inpila, xa, ya, rep);

                    if (rep == false)
                    {

                        inpila++;

                        pila[inpila, 0] = xa;
                        pila[inpila, 1] = ya;
                        pila[inpila, 2] = nivel + 1;
                        pila[inpila, 3] = padre;
                        pila[inpila, 4] = index;
                        index++;
                        
                    }

                    xa = 0;
                    rep = BuscaVerticesp(cpila, incpila, xa, ya);
                   
                    if (rep == false)
                        rep = BuscaVerticespila(pila, inpila, xa, ya, rep);

                   
                    if (rep == false)
                    {

                        inpila++;

                        pila[inpila, 0] = xa;
                        pila[inpila, 1] = ya;
                        pila[inpila, 2] = nivel + 1;
                        pila[inpila, 3] = padre;
                        pila[inpila, 4] = index;
                        index++;


                       

                    }


                    xa = x;
                    ya = y;
                    while (xa < 3 && ya > 0)
                    {
                        ya--;
                        xa++;

                    }
                    rep = BuscaVerticesp(cpila, incpila, xa, ya);
                    if (rep == false)
                        rep = BuscaVerticespila(pila, inpila, xa, ya, rep);




                    if (rep == false)
                    {


                        inpila++;

                        pila[inpila, 0] = xa;
                        pila[inpila, 1] = ya;
                        pila[inpila, 2] = nivel + 1;
                        pila[inpila, 3] = padre;
                        pila[inpila, 4] = index;
                        index++;

                        

                    }
                    xa = x ;
                    ya = y ;

                    ya = 4;
                    rep = BuscaVerticesp(cpila, incpila, xa, ya);
                    if (rep == false)
                        rep = BuscaVerticespila(pila, inpila, xa, ya, rep);


                    if (rep == false)
                    {

                        inpila++;

                        pila[inpila, 0] = xa;
                        pila[inpila, 1] = ya;
                        pila[inpila, 2] = nivel + 1;
                        pila[inpila, 3] = padre;
                        pila[inpila, 4] = index;
                        index++;


                        
                    }

                    ya = 0;
                    rep = BuscaVerticesp(cpila, incpila, xa, ya);
                    if (rep == false)
                        rep = BuscaVerticespila(pila, inpila, xa, ya, rep);


                    if (rep == false)
                    {

                        inpila++;

                        pila[inpila, 0] = xa;
                        pila[inpila, 1] = ya;
                        pila[inpila, 2] = nivel + 1;
                        pila[inpila, 3] = padre;
                        pila[inpila, 4] = index;
                        index++;

                      

                    }

                    xa = x ;
                    ya = y ;

                    while (ya < 4 && xa > 0)
                    {
                        ya++;
                        xa--;

                    }
                    rep = BuscaVerticesp(cpila, incpila, xa, ya);
                    if (rep == false)
                        rep=BuscaVerticespila(pila, inpila, xa, ya, rep);


                    if (rep == false)
                    {

                        inpila++;

                        pila[inpila, 0] = xa;
                        pila[inpila, 1] = ya;
                        pila[inpila, 2] = nivel + 1;
                        pila[inpila, 3] = padre;
                        pila[inpila, 4] = index;
                        index++;

                       
                    }



                }






                pos[0, 0] = 50;
                pos[0, 1] = 490;

                string sa = "";

                sa += x.ToString();
                sa += ",";
                sa += y.ToString();

                V[0] = new TextBox();
                V[0].Location = new Point(Lh, Lv);
                V[0].Name = "inicio";
                V[0].Size = new Size(50, 20);
                V[0].TabIndex = 0;
                V[0].Text = sa;
                V[0].BackColor = Color.AliceBlue;

                Controls.Add(V[0]);
                panel1.Controls.Add(V[0]);

              


            }

            int[,] ccp = new int[20, 5];
            int incc = 0;


           
            for (int n = 0; n <= incpila; n++)//reacomoda los las vertices
            {
                for (int m = 0; m < incpila; m++)
                {
                    
                    if (cpila[m, 2] == n)
                    {
                      
                        ccp[incc, 0] = cpila[m, 0];//x
                        ccp[incc, 1] = cpila[m, 1];//y
                        ccp[incc, 3] = cpila[m, 2];//padre
                        ccp[incc, 2] = cpila[m, 3];//nivel
                        ccp[incc, 4] = cpila[m, 4];//index
                        incc++;
                    }


                }
            }






            int indice = 1; Lv = 130;
            int NN;
            int grid = 980;


            incc = 0;
            for (int n = 0; n <= incpila; n++)//reacomoda los las vertices por index
            {
                for (int m = 0; m < incpila; m++)
                {

                    if (ccp[m, 4] == n)
                    {

                        cpila[incc, 0] = ccp[m, 0];//x
                        cpila[incc, 1] = ccp[m, 1];//y
                        cpila[incc, 3] = ccp[m, 2];//padre
                        cpila[incc, 2] = ccp[m, 3];//nivel
                        cpila[incc, 4] = ccp[m, 4];//index
                        incc++;
                    }


                }
            }


            bool romper = false;
            while (indice < incc)//posiciona nodos
            {

                

                NN = Busca_verticesmnp(ccp, indice, incc);

           

                int nota = grid / (NN * 2);

                string iv = "";
                
                for (int y = 1; y < NN * 2; y += 2)
                {
                    iv += cpila[indice, 0].ToString();
                    iv += ",";
                    iv += cpila[indice, 1].ToString();


                    //imprimir vertice
                    Lh = (nota * y);
                    V[indice] = new TextBox();
                    V[indice].Location = new Point(Lh, Lv);
                    V[indice].Name = "vertice";
                    V[indice].Size = new Size(50, 20);
                    V[indice].TabIndex = indice;
                    V[indice].Text = iv;
                    V[indice].BackColor = Color.AliceBlue;
                    V[indice].Visible = true;
                    Controls.Add(V[indice]);
                    panel1.Controls.Add(V[indice]);
                    ///////////////////////////////////////////////////

                 
                    iv = "";


                    pos[indice, 0] = Lv;
                    pos[indice, 1] = Lh;

                    if (cpila[indice, 0] == xf && cpila[indice, 1] == yf)
                    {

                       

                        cpila[indice + 1, 0] = xf;
                        cpila[indice + 1, 1] = yf;
                        cpila[indice + 2, 0] = xf;
                        cpila[indice + 2, 1] = yf;
                        romper = true;
                        break;
                        
                    }
                        

                    indice++;

                  
                }
                Lv = Lv + 80;

                if (romper==true)
                {

                    //MessageBox.Show(cpila[indice, 0].ToString() + "," + cpila[indice, 1].ToString());
                    break;

                }

            }

            int bug = 1;
            if (indice == incc)
                bug--;


            for (int ñ = 1; ñ <indice+bug; ñ++)//grega lineas
            {
                Pen myPen;
                myPen = new Pen(Color.Black);
                Graphics formGraphics;
                lineas = formGraphics = panel1.CreateGraphics();
                panel1.CreateGraphics().Save();
                formGraphics.DrawLine(myPen, pos[ñ, 1] + 25, pos[ñ, 0], pos[cpila[ñ, 3], 1] + 25, pos[cpila[ñ, 3], 0]);
                myPen.Dispose();
                formGraphics.Dispose();

                

                
           

            }



            //for (int ñ = 1; ñ <=incc; ñ++)//grega lineas
            //{

            //    Pen myPen;
            //    myPen = new Pen(Color.Black);
            //    Graphics formGraphics;
            //    formGraphics = panel1.CreateGraphics();
            //    formGraphics.DrawLine(myPen, pos[y, 1] + 25, pos[y, 0], pos[ccp[y, 2], 1] + 25, ccp[pila[y, 2], 0]);
            //    formGraphics.DrawLine(myPen, 245, 130, 450, 50);
            //    myPen.Dispose();
            //    formGraphics.Dispose();



            //}
































            cad += Environment.NewLine;
            cad += "visitados";
            cad += Environment.NewLine;


            for (int o = 0; o < incpila; o++)
            {
                cad += cpila[o, 0].ToString();
                cad += ",";
                cad += cpila[o, 1].ToString();
                cad += ",";
                cad += cpila[o, 2].ToString();
                cad += ",";
                cad += cpila[o, 3].ToString();
                cad += ",";
                cad += cpila[o, 4].ToString();
                cad += Environment.NewLine;

            }


            cad += Environment.NewLine;
            cad += "encontrados";
            cad += Environment.NewLine;

            for (int o = 0; o <= inpila; o++)
            {
                cad += pila[o, 0].ToString();
                cad += ",";
                cad += pila[o, 1].ToString();
                cad += ",";
                cad += pila[o, 2].ToString();
                cad += ",";
                cad += pila[o, 3].ToString();
                cad += ",";
                cad += pila[o, 4].ToString();
                cad += Environment.NewLine;

            }

            cad += Environment.NewLine;
            cad += "ordenados";
            cad += Environment.NewLine;


            for (int o = 0; o < incc; o++)
            {
                cad += ccp[o, 0].ToString();
                cad += ",";
                cad += ccp[o, 1].ToString();
                cad += ",";
                cad += ccp[o, 2].ToString();
                cad += ",";
                cad += ccp[o, 3].ToString();
                cad += ",";
                cad += ccp[o, 4].ToString();
                cad += Environment.NewLine;

            }

            cad += Environment.NewLine;
            cad += "posiciones";
            cad += Environment.NewLine;


            for (int o = 0; o < incpila; o++)
            {
                cad += pos[o, 0].ToString();
                cad += ",";
                cad += pos[o, 1].ToString();
                cad += ",";
                
                cad += Environment.NewLine;

            }

            textBox2.Text = inpila.ToString();
            textBox3.Text = incpila.ToString();
            textBox1.Text = cad.ToString();






        }


        public int Busca_verticesmnp(int[,] vertices, int indice, int inccp)
        {
            int cont = 0;
            for (int k = 0; k <= inccp; k++)
            {
                if (vertices[indice, 3] == vertices[k, 3])
                {
                    cont++;
                }
            }
            return cont;
        }



        public bool BuscaVerticesp(int[,] vertice, int indice, int x, int y)
        {
            bool rep = false;

            for (int k = 0; k < indice; k++)
            {
                if (vertice[k, 0] == x && vertice[k, 1] == y)
                {
                    rep = true;
                    break;
                }
                else
                    rep = false;


            }

            return rep;
        }



















































        public void Agregavertices()
        {




            int[,] vertices = new int[16, 4];
            int[] cola = new int[20];
            
            int xa = 0, ya = 0;
            icola = 0;

            if (xF.Text == "*" && yF.Text == "*")
            {


                xf = int.Parse(xI.Text);
                yf = int.Parse(yI.Text);
              

            }
            else
            {

                xf = int.Parse(xF.Text);
                yf = int.Parse(yF.Text);

            }

            pos[0, 0] = 50;
            pos[0, 1] = 490;


            xa = x = int.Parse(xI.Text);
            ya = y = int.Parse(yI.Text);





            cola[0] = 0;
            vertices[0, 0] = xa;
            vertices[0, 1] = ya;
            vertices[0, 2] = 5;
            vertices[0, 3] = 0;
            string sa = "";

            sa += xa.ToString();
            sa += ",";
            sa += ya.ToString();

            V[0] = new TextBox();
            V[0].Location = new Point(Lh, Lv);
            V[0].Name = "inicio";
            V[0].Size = new Size(50, 20);
            V[0].TabIndex = 0;
            V[0].Text = sa;
            V[0].BackColor = Color.AliceBlue;

            Controls.Add(V[0]);
            panel1.Controls.Add(V[0]);
           

            int k = icola;
            while (k <= icola && encontrado == false)
            {

                Nuevos_Vertices(vertices, xa, ya);

                x = xa = vertices[k, 0];
                y = ya = vertices[k, 1];
               
                k++;
            }




          

            int indice = 1;Lv = 130;
            int NN;
            int grid = 980;


            while (indice <= icola)//posiciona nodos
            {
                
                NN = Busca_verticesmn(vertices, indice);
               
                int nota = grid / (NN*2);

                string iv = "";
                for (int y = 1; y < NN*2; y += 2)
                {
                    iv += vertices[indice, 0].ToString();
                    iv += ",";
                    iv += vertices[indice, 1].ToString();


                   
                    Lh = (nota * y) ;
                    V[indice] = new TextBox();
                    V[indice].Location = new Point(Lh, Lv);
                    V[indice].Name = "vertice";
                    V[indice].Size = new Size(50, 20);
                    V[indice].TabIndex = indice;
                    V[indice].Text = iv;
                    V[indice].BackColor = Color.AliceBlue;
                    Controls.Add(V[indice]);
                    panel1.Controls.Add(V[indice]);
                    

                    pos[indice, 0] = Lv;
                    pos[indice, 1] = Lh;
                    
                    

                   

                    indice++;
                    iv = "";//limpia cadena

                }
                Lv = Lv+80;

               
            }//////////////////////////////////////


            for (int y = 1; y <= icola; y++)
            {

                Pen myPen;
                myPen = new Pen(Color.Black);
                Graphics formGraphics;
                formGraphics = panel1.CreateGraphics();
                formGraphics.DrawLine(myPen, pos[y, 1]+25, pos[y, 0], pos[vertices[y,2], 1]+25, pos[vertices[y,2], 0]);
                myPen.Dispose();
                formGraphics.Dispose();
                
              



            }

            string cad = "";

            for (int o = 0; o <= icola; o++)
            {
                cad += pos[o, 0].ToString();
                cad += ",";
                cad += pos[o, 1].ToString();
                
                cad += Environment.NewLine;
            }



           
        }

     

        public int Busca_verticesmn(int[,] vertices, int indice)
        {
            int cont = 0;
            for (int k = 0; k <=icola; k++)
            {
                if (vertices[indice, 3] == vertices[k, 3])
                {
                    cont++;
                }
            }
            return cont;
        }


        public void Nuevos_Vertices(int[,] vertices, int xa , int ya )
        {
            int aux;
            bool rep = false;
            string iv = "";//imprimir en vertice
            
            for (int k = 0; k < 1; k++)//aplica movimientos de jarras, para buscar nuevas vertices
            {

               
                xa = 0;
                
                rep = BuscaVertices(vertices, icola, xa, ya, rep);

                if (rep == false)
                {

                    aux = Buscar_pos(vertices);

                    iv += xa.ToString();
                    iv += ",";
                    iv += ya.ToString();
                    Lh = pos[aux, 1] + 40;
                    Lv = pos[aux, 0] + 40;
                   


                    icola++;
                    vertices[icola, 0] = xa;
                    vertices[icola, 1] = ya;
                    vertices[icola, 2] = aux;
                    vertices[icola, 3] = vertices[aux, 3] + 1;
                   



                    if (xf == xa && yf == ya)
                    {

                        encontrado = true;
                       // break;


                    }




                }

                xa = 3;

                rep = BuscaVertices(vertices, icola, xa, ya, rep);


                if (rep == false)
                {


                    aux = Buscar_pos(vertices);
                    Lh = pos[aux, 1] + 40;
                    Lv = pos[aux, 0] + 40;
                    iv += xa.ToString();
                    iv += ",";
                    iv += ya.ToString();

                    


                    icola++;
                    vertices[icola, 0] = xa;
                    vertices[icola, 1] = ya;
                    vertices[icola, 2] = aux;
                    vertices[icola, 3] = vertices[aux, 3] + 1;
                    


                 

                    if (xf == xa && yf == ya)
                    {
                        encontrado = true;
                       // break;


                    }



                }


                xa = x;
                ya = y;


                while (xa < 3 && ya > 0)
                {
                    ya--;
                    xa++;

                }

                rep = BuscaVertices(vertices, icola, xa, ya, rep);
                if (rep == false)
                {
                    aux = Buscar_pos(vertices);
                    Lh = pos[aux, 1] + 40;
                    Lv = pos[aux, 0] + 40;
                    iv += xa.ToString();
                    iv += ",";
                    iv += ya.ToString();

                   




                    icola++;
                    vertices[icola, 0] = xa;
                    vertices[icola, 1] = ya;
                    vertices[icola, 2] = aux;
                    vertices[icola, 3] = vertices[aux, 3] + 1;
                    


                    if (xf == xa && yf == ya)
                    {
                        encontrado = true;
                        //break;


                    }

                }
                ya = y;
                xa = x;

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                ya = 0;
                rep = BuscaVertices(vertices, icola, xa, ya, rep);

                if (rep == false)
                {
                    aux = Buscar_pos(vertices);
                    Lh = pos[aux, 1] + 40;
                    Lv = pos[aux, 0] + 40;
                    iv += xa.ToString();
                    iv += ",";
                    iv += ya.ToString();

                   
                    

                    icola++;
                    vertices[icola, 0] = xa;
                    vertices[icola, 1] = ya;
                    vertices[icola, 2] = aux;
                    vertices[icola, 3] = vertices[aux, 3] + 1;
                   


                    if (xf == xa && yf == ya)
                    {
                        encontrado = true;
                       /// break;


                    }


                }

               
                ya = 4;

                rep = BuscaVertices(vertices, icola, xa, ya, rep);
              

                if (rep == false)
                {
                    aux = Buscar_pos(vertices);
                    Lh = pos[aux, 1] + 40;
                    Lv = pos[aux, 0] + 40;
                    iv += xa.ToString();
                    iv += ",";
                    iv += ya.ToString();

                    
                    

                    icola++;
                    vertices[icola, 0] = xa;
                    vertices[icola, 1] = ya;
                    vertices[icola, 2] = aux;
                    vertices[icola, 3] = vertices[aux, 3] + 1;
                    

                    if (xf == xa && yf == ya)
                    {
                        encontrado = true;
                       // break;


                    }

                }


                xa = x;
                ya = y;


                while (ya < 4 && xa > 0)
                {
                    ya++;
                    xa--;

                }

                rep = BuscaVertices(vertices, icola, xa, ya, rep);
                if (rep == false)
                {
                    aux = Buscar_pos(vertices);
                    Lh = pos[aux, 1] + 40;
                    Lv = pos[aux, 0] + 40;
                    iv += xa.ToString();
                    iv += ",";
                    iv += ya.ToString();

                   
                    
                    icola++;
                    vertices[icola, 0] = xa;
                    vertices[icola, 1] = ya;
                    vertices[icola, 2] = aux;
                    vertices[icola, 3] = vertices[aux, 3] + 1;
                   

                    if (xf == xa && yf == ya)
                    {
                        encontrado = true;
                        //break;


                    }

                }
            }

           




           


        }


        public int Buscar_pos(int[,] v)
        {
            int aux=0;
            for (int k = 0; k < icola; k++)
            {

                if (v[k, 0] == x && v[k, 1] == y)
                {
                    aux = k;
                    
                }

            }
            return aux;

        }




        public bool BuscaVertices(int[,] vertice, int icola, int x, int y, bool rep)
        {

            for (int k = icola; k >= 0; k--)
            {
                if (vertice[k, 0] == x && vertice[k, 1] == y)
                {
                    rep = true;
                    break;
                }
                else
                    rep = false;


            }

            return rep;
        }



       

        public bool BuscaVerticespila(int[,] vertice, int icola, int x, int y, bool rep)
        {

            for (int k = icola; k >= 0; k--)
            {
                if (vertice[k, 0] == x && vertice[k, 1] == y)
                {
                    rep = true;
                    break;
                }
                else
                    rep = false;


            }

            return rep;
        }





    }
}