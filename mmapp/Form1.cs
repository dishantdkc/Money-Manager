using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Finisar.SQLite;
using System.IO;



namespace mmapp
{
    
    public partial class Form1 : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        

        //----------------------------------------------------------

        int Gid=0, GBudget;
        string Gdt1, Gdt2;
        string Ginc;


        

        //----------------------------------------------------------

        Label[] EvntSr = new Label[25];
        Label[] EvntMny = new Label[25];
        Label[] EvntDt = new Label[25];
        Label[] EvntAmt = new Label[25];
        Label[] EvntCat = new Label[25];
        Label no = new Label();
        int Evntnos=0,TtlYt=0;

        //---------------------------------------------------------
         
        public Form1()
        {
            InitializeComponent();
        }



        private void ShowInstructions()
        {
            main mn = new main();
            mn.Show();
        }

        private bool IsFirstTime()
        {
            bool first = new bool();
            first = false;
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=mmapp.sqlite;Version=3;New=False;Compress=True;");

                sqlite_conn.Open();

                sqlite_cmd = sqlite_conn.CreateCommand();
            }
            catch
            {
                first = true;
            }


            return first;
        }

        private void CreateNewDatabase()
        {
            sqlite_conn = new SQLiteConnection("Data Source=mmapp.sqlite;Version=3;New=True;Compress=True;");

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "CREATE TABLE regis (id integer primary key , amt integer , dt1 varchar(50) , dt2 varchar(50), inc varchar(100));";

            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "CREATE TABLE evnts (id integer , amt integer , dt varchar(50) , cat varchar(10) , code integer , mny varchar(50));";

            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "CREATE TABLE rmnder(id integer primary key , dt1 varchar(50) , dt2 varchar(50) , cat varchar(10) , txt varchar(100));";

            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "CREATE TABLE list (id varchar(10) , name varchar(100));";

            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('a','food');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('b','mobile recharge');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('c','partys');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('d','clothes');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('e','transport');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('f','books');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('g','fees');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('h','stationary');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('i','acedemic');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('j','grocery');";

            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO list (id , name) VALUES('k','other');";

            sqlite_cmd.ExecuteNonQuery();


        }

        private void ShowRegularMainPage()
        {
            HideBudgetPnl();
            ReadRegis();
            SetFirstLine();
            AddEvnts();
        }

        private void AddEvnts()
        {
            ClrEvnts();
            try
            {
                //MessageBox.Show(Gid.ToString());
                no.Visible = false;
                sqlite_cmd.CommandText = "SELECT * FROM evnts WHERE code=" + Gid;
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    EvntSr[Evntnos] = new Label();
                    EvntMny[Evntnos] = new Label();
                    EvntDt[Evntnos] = new Label();
                    EvntAmt[Evntnos] = new Label();
                    EvntCat[Evntnos] = new Label();


                    EvntSr[Evntnos].Text = (Evntnos+1).ToString();
                    EvntMny[Evntnos].Text = sqlite_datareader["mny"].ToString();
                    EvntDt[Evntnos].Text = sqlite_datareader["dt"].ToString();
                    EvntAmt[Evntnos].Text = sqlite_datareader["amt"].ToString();
                    EvntCat[Evntnos].Text = sqlite_datareader["cat"].ToString();

                    //MessageBox.Show(sqlite_datareader["mny"].ToString());

                    EvntSr[Evntnos].Size = new Size(25, 25);
                    EvntMny[Evntnos].Size = new Size(50, 25);
                    EvntDt[Evntnos].Size = new Size(65, 25);
                    EvntAmt[Evntnos].Size = new Size(50, 25);
                    EvntCat[Evntnos].Size = new Size(70, 25);


                    EvntSr[Evntnos].Location = new Point(5, Evntnos * 25 + 5);
                    EvntMny[Evntnos].Location = new Point(35, Evntnos * 25 + 5);
                    EvntDt[Evntnos].Location = new Point(110, Evntnos * 25 + 5);
                    EvntAmt[Evntnos].Location = new Point(180, Evntnos * 25 + 5);
                    EvntCat[Evntnos].Location = new Point(255, Evntnos * 25 + 5);


                    EvntPnlInr.Controls.Add(EvntSr[Evntnos]);
                    EvntPnlInr.Controls.Add(EvntMny[Evntnos]);
                    EvntPnlInr.Controls.Add(EvntDt[Evntnos]);
                    EvntPnlInr.Controls.Add(EvntAmt[Evntnos]);
                    EvntPnlInr.Controls.Add(EvntCat[Evntnos]);



                    TtlYt += Convert.ToInt32(sqlite_datareader["amt"].ToString());
                    TtlYtLbl.Text = TtlYt.ToString();
                    int rm=GBudget - TtlYt;
                    
                    if (rm > 0)
                    {
                        Rmning.ForeColor = Color.Black;
                        Rmning.Text = "Remaining Rs:" + rm.ToString();
                    }
                    if (rm < 0)
                    {
                        Rmning.ForeColor = Color.Red;
                        Rmning.Text = "OMG!!      You Have Gone Out Of Budget !!!!!!!!!!!!!!!!!!!!!!!!";
                    }
                    Evntnos++;

                }
                sqlite_datareader.Close();
            }
            catch(Exception ex)
            {
                 
                 no.Visible = true;
                no.Text = "No Event Added Yet   !!!! \n  Add By clicking on New Event button in top toolbar ";
                no.Location = new Point(10, 10);
                no.Size = new Size(500, 50);
                EvntPnlInr.Controls.Add(no);
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("");
            }
        }

        private void ClrEvnts()
        {
            //MessageBox.Show("clr");
            try
            {
              //  MessageBox.Show("clrtry");
                for (int i = 0; i <= Evntnos; i++)
                {
                    EvntSr[Evntnos].Dispose();
                    EvntMny[Evntnos].Dispose();
                    EvntDt[Evntnos].Dispose();
                    EvntAmt[Evntnos].Dispose();
                    EvntCat[Evntnos].Dispose();
                    EvntPnlInr.Controls.Clear();
                //    MessageBox.Show("clrfr");
                }

            }
            catch
            { }
                Evntnos = 0;
                TtlYt = 0;
                Rmning.Text = "";
                TtlYtLbl.Text = "0";

        }

        private void ShowNewEvntPnl()
        {
            ResetNewEvntPnl();
            NewEvntPnl.Visible = true;
            NewEvntPnl.Size = new Size(560, 200);
            NewEvntPnl.Location = new Point(0, 0);
        }

        private void HideNewEvntPnl()
        {
            ResetNewEvntPnl();
            NewEvntPnl.Visible = false;
            ShowRegularMainPage();
        }

        private void ResetNewEvntPnl()
        {
            NewEvntMny.Text = "";
            NewEvntAmt.Text = "";
            NewEvntDt.Text = DateTime.Today.Date.ToString();
            NewEvntCat.Items.Clear();
        }

        private string GetEvntNo()
        {
            int no=0;
            string EvntLst="";
            try
            {
                sqlite_cmd.CommandText = "SELECT * FROM evnts where code="+Gid;
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    //if()//--------------------------------------------------------------------------------------------
                }
                
            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return EvntLst;
           // return no;
        }

        private void SetFirstLine()
        {
            //string[] s1= Gdt1.Split('-');
            FirstLineLable.Text = "Amount Rs. " + GBudget.ToString() + "   From " + Gdt1 + "    to   " + Gdt2;
        }

        private void ReadRegis()
        {
            try
            {
                sqlite_cmd.CommandText = "SELECT MAX(id) FROM regis";

                sqlite_datareader = sqlite_cmd.ExecuteReader();

                sqlite_datareader.Read();

                Gid = Convert.ToInt32(sqlite_datareader[0]);

                sqlite_datareader.Close();

                sqlite_cmd.CommandText = "SELECT * FROM regis WHERE id=" + Gid;

                sqlite_datareader = sqlite_cmd.ExecuteReader();

                sqlite_datareader.Read();

                GBudget = Convert.ToInt32(sqlite_datareader["amt"]);

                Gdt1 = sqlite_datareader["dt1"].ToString();

                Gdt2 = sqlite_datareader["dt2"].ToString();

                Ginc = sqlite_datareader["inc"].ToString();

                sqlite_datareader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //MessageBox.Show(Gid.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main();   
        }

        private void main()
        {
            if (IsFirstTime())
            {

                ShowInstructions();
                CreateNewDatabase();
                ShowBudgetPnl();
            }
            else
            {
                ShowRegularMainPage();
            }
        }

        private void BPdtfrom_ValueChanged(object sender, EventArgs e)
        {
            BPdtto.MinDate = BPdtfrom.Value;
        }

        private void BPSubmit_Click(object sender, EventArgs e)
        {
            int budget;
            string dtfrom, dtto;
            string[] dt;
            

            budget = Convert.ToInt32(BPBudget.Value);
            dtfrom = BPdtfrom.Value.Date.ToString();//.Day + "00" + BPdtfrom.Value.Month.ToString() + "00" + BPdtfrom.Value.Year;
            dtto = BPdtto.Value.Date.ToString();//.Day + "00" + BPdtto.Value.Month.ToString() + "00" + BPdtto.Value.Year;
            string inc = "";

            dt = dtfrom.Split(' ');
            

            dtfrom = dt[0];

            dt = dtto.Split(' ');

            dtto = dt[0];
            //MessageBox.Show(dt[0]);
            
            //MessageBox.Show(dtfrom);
            if (checkBox1.Checked == true)
                inc += "a";
            if (checkBox2.Checked == true)
                inc += "b";
            if (checkBox3.Checked == true)
                inc += "c";
            if (checkBox4.Checked == true)
                inc += "d";
            if (checkBox5.Checked == true)
                inc += "e";
            if (checkBox6.Checked == true)
                inc += "f";
            if (checkBox7.Checked == true)
                inc += "g";
            if (checkBox8.Checked == true)
                inc += "h";
            if (checkBox9.Checked == true)
                inc += "i";
            if (checkBox10.Checked == true)
                inc += "j";

            AddBudget(Gid+1, budget, dtfrom, dtto, inc);

            HideBudgetPnl();

            ShowRegularMainPage();



        }

        private void ShowBudgetPnl()
        {
            BudgetPnl.Location = new Point(0, 0);
            BudgetPnl.Size = new Size(560, 455);
            BudgetPnl.Visible = true;
            toolStrip1.Visible = false;
        }

        private void HideBudgetPnl()
        {
            BPBudget.Value = 1;
            BPdtfrom.Value = DateTime.Today.Date;
            BudgetPnl.Visible = false;
            toolStrip1.Visible = true;
        }

        private void AddBudget(int id, int budget, string dtg1, string dtg2, string str)
        {
            try
            {
                //MessageBox.Show(dtg2);
                sqlite_cmd.CommandText = "INSERT INTO regis (id , amt , dt1 , dt2 , inc) VALUES ("+id+","+budget+",'"+dtg1.ToString()+"','"+dtg2.ToString()+"','"+str.ToString()+"');";
                //qlite_cmd.bin

                    //+ 1d + "," + budget + "," + dtg1 + "," + dtg2 + "," + str + ");";

               
                sqlite_cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("unbl");
            }
            main();
        }

        private void CloseApp()
        {
            this.Close();

        }


        private void close_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void NewEvnt_Click(object sender, EventArgs e)
        {
            ShowNewEvntPnl();
        }

        private void NewEvntCancel_Click(object sender, EventArgs e)
        {
            HideNewEvntPnl();
        }

        private void NewEvntMny_SelectedIndexChanged(object sender, EventArgs e)
        {

            NewEvntCat.Items.Clear();
            if (NewEvntMny.Text == "Spend")
            {
                char[] ch = Ginc.ToCharArray();
                //MessageBox.Show(Ginc);
                for (int i = 0; i < Ginc.Length; i++)
                {
                    //ch[i] = Convert.ToChar(Convert.ToInt32(ch[i]) + 45);
                    NewEvntCat.Items.Add(GetName(ch[i]));  
                    //MessageBox.Show(ch[i].ToString());
                    
                }
            }
            else if (NewEvntMny.Text == "Recieved")
            {
                NewEvntCat.Items.Add("Earning");
                NewEvntCat.Items.Add("Reward");
            }
        }

        private string GetName(char a)
        {
            string s = "";
            switch (a)
            {
                case 'a':
                    {
                        s = "food";
                    }
                    break;
                case 'b':
                    {
                        s = "Mobile Recharge";
                    }
                    break;
                case 'c':
                    {
                        s = "Partys";
                    }
                    break;
                case 'd':
                    {
                        s = "Clothes";
                    }
                    break;
                case 'e':
                    {
                        s = "Transport";
                    }
                    break;
                case 'f':
                    {
                        s = "Books";
                    }
                    break;
                case 'g':
                    {
                        s = "Fees";
                    }
                    break;
                case 'h':
                    {
                        s = "Stationary";
                    }
                    break;
                case 'i':
                    {
                        s = "Acedemics";
                    }
                    break;
                case 'j':
                    {
                        s = "Grocery";
                    }
                    break;
                case 'k':
                    {
                        s = "othes";
                    }
                    break;

                    
            }
            return s;
        }

        private void NewEvntAddEvnt_Click(object sender, EventArgs e)
        {
            string[] st= NewEvntDt.Text.Split(' ');
            try
            {

            sqlite_cmd.CommandText = "INSERT INTO evnts (id , amt , dt , cat , code , mny) VALUES("+(Evntnos+1)+" , "+Convert.ToInt32(NewEvntAmt.Text)+" , '"+st[0].ToString()+"' , '"+ NewEvntCat.Text+"' , "+Gid+" , '"+NewEvntMny.Text.ToString()+"')";
            
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            HideNewEvntPnl();
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            sqlite_conn.Close();

            if (File.Exists("mmapp.sqlite"))
            {
                File.Delete("mmapp.sqlite");
            }
            main();
        }

        private void New_Click(object sender, EventArgs e)
        {
            ShowBudgetPnl();
        }

        
        
      

























      
    }
}
