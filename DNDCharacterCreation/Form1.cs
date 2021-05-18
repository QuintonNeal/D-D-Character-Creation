using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This is for the use of SQL - Will need to be on every form
using System.Data.SqlClient;

namespace DNDCharacterCreation
{
    public partial class Form1 : Form
    {
        ////////////////////////////////////////////////////////////////////////////////////
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283S2140;User ID=ISYS4283S2140;Password=LZ23uns$";
        SqlConnection connection; //Function to open an sql database
        SqlCommand command; //Used to execute sql statements I think???
        SqlDataReader datareader;
        ////////////////////////////////////////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Broke this into a seperate funtion so it could be called from here and other funtions
                Load_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }



        //Use this funtion when the form loads or needs to be reset
        private void Load_Form()
        {
            try
            {
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                connection = new SqlConnection(connectionstring);

                connection.Open(); //Opens the connection to the database
                string sql = "SELECT CharacterName FROM Character";
                command = new SqlCommand(sql, connection);
                datareader = command.ExecuteReader();


                //Clear combobox so it can be loaded with fresh data
                cmbChar.Items.Clear();

                //Uploads characters into the character combo box
                while (datareader.Read())
                {
                    cmbChar.Items.Add(datareader[0].ToString());
                }
                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command
                datareader.Close(); //Closes the datareader
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void cmbChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (cmbChar.SelectedIndex > -1)
                {
                    connection = new SqlConnection(connectionstring);

                    connection.Open(); //Opens the connection to the database
                    string sql = "SELECT CharacterID, PlayerName, Race, Class, Strength, Dexterity, Intelligence, HitPoints FROM Character WHERE CharacterName = '" + cmbChar.SelectedItem.ToString() + "'"; //Coding in C# between the plusses
                    command = new SqlCommand(sql, connection);
                    datareader = command.ExecuteReader();
                    while (datareader.Read())
                    {
                        CharacterIDTextBox.Text = datareader[0].ToString();
                        PlayerTextBox.Text = datareader[1].ToString();
                        RaceTextBox.Text = datareader[2].ToString();
                        ClassTextBox.Text = datareader[3].ToString();
                        StrengthTextBox.Text = datareader[4].ToString();
                        DexterityTextBox.Text = datareader[5].ToString();
                        IntelligenceTextBox.Text = datareader[6].ToString();
                        HitPointTextBox.Text = datareader[7].ToString();
                    }
                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command
                    datareader.Close(); //Closes the datareader

                    //Set the character name textbox to be correct
                    CharacterNameTextBox.Text = cmbChar.SelectedItem.ToString();



                    lstEquip.Items.Clear();
                    connection.Open(); //Opens the connection to the database
                    sql = "SELECT EquipmentName FROM Equipment";
                    command = new SqlCommand(sql, connection);
                    datareader = command.ExecuteReader();

                    //Inserts the listbox with items from the selected character's equipment
                    while (datareader.Read())
                    {
                        lstEquip.Items.Add(datareader[0].ToString());
                    }
                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command
                    datareader.Close(); //Closes the datareader

                    var sql2 = "SELECT * FROM Inventory WHERE CharacterID = '" + CharacterIDTextBox.Text + "'";
                    var da = new SqlDataAdapter(sql2, connection);
                    var ds = new DataSet();  //Dataset - basical a spreadsheet
                    da.Fill(ds); //Take the data adapter and fill the dataset
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Hey! Choose a character you tool!");
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void lstEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //This if statement makes it so blank space can't be selected. There was an error making the system crash
                if (lstEquip.GetItemText(lstEquip.SelectedItem) != "")
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open(); //Opens the connection to the database
                    string sql = "SELECT equipmentID, Type, Size, Rarity, EquipmentName FROM Equipment WHERE EquipmentName = '" + lstEquip.SelectedItem.ToString() + "'"; //Codinf in C# between the plusses
                    command = new SqlCommand(sql, connection);
                    datareader = command.ExecuteReader();

                    //Populate textboxes with the information of the item chosen in the listbox
                    while (datareader.Read())
                    {
                        EquipIDTxtBox.Text = datareader[0].ToString();
                        TypeTxtBox.Text = datareader[1].ToString();
                        SizeTxtBox.Text = datareader[2].ToString();
                        RarityTxtBox.Text = datareader[3].ToString();
                        equipmentNameTxtBox.Text = datareader[4].ToString();
                    }
                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command
                    datareader.Close(); //Closes the datareader
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }



        //Inserts data into the datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //////////////////////////////////////////////////////////////////////////
                AcquireDateTxtBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                LossDateTxtBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                StatusTxtBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                SlotTxtBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //////////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }




        //Adds a new character to the database
        private void btnInsertC_Click(object sender, EventArgs e)
        {
            try
            {
                if (CharacterNameTextBox.Text != "")
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open(); //Opens the connection to the database


                    int answer;
                    string sql = "INSERT INTO Character VALUES (@name, @pname, @race, @class, @str, @dex, @int, @HP)"; //The @s are placeholders (scalar variables). Telling system that they will be seen later in the code


                    command = new SqlCommand(sql, connection);

                    //Connects the correct textbox data with what attribute they will be put into
                    command.Parameters.AddWithValue("@name", CharacterNameTextBox.Text);
                    command.Parameters.AddWithValue("@pname", PlayerTextBox.Text);
                    command.Parameters.AddWithValue("@race", RaceTextBox.Text);
                    command.Parameters.AddWithValue("@class", ClassTextBox.Text);
                    command.Parameters.AddWithValue("@str", StrengthTextBox.Text);
                    command.Parameters.AddWithValue("@dex", DexterityTextBox.Text);
                    command.Parameters.AddWithValue("@int", IntelligenceTextBox.Text);
                    command.Parameters.AddWithValue("@HP", HitPointTextBox.Text);

                    answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command

                    MessageBox.Show("Successfully entered " + answer + " Character");
                }
                else
                {
                    MessageBox.Show("ERROR! Enter a character name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnUpdateC_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open(); //Opens the connection to the database


                int answer;
                string sql = "UPDATE Character SET CharacterName=@name, PlayerName=@pname, Race=@race, Class=@class, Strength=@str, Dexterity=@dex, Intelligence=@int, HitPoints=@HP WHERE CharacterID=@CID";


                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@name", CharacterNameTextBox.Text);
                command.Parameters.AddWithValue("@pname", PlayerTextBox.Text);
                command.Parameters.AddWithValue("@race", RaceTextBox.Text);
                command.Parameters.AddWithValue("@class", ClassTextBox.Text);
                command.Parameters.AddWithValue("@str", StrengthTextBox.Text);
                command.Parameters.AddWithValue("@dex", DexterityTextBox.Text);
                command.Parameters.AddWithValue("@int", IntelligenceTextBox.Text);
                command.Parameters.AddWithValue("@HP", HitPointTextBox.Text);
                command.Parameters.AddWithValue("@CID", CharacterIDTextBox.Text);

                answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command

                MessageBox.Show("Successfully modified " + answer + " Character");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open(); //Opens the connection to the database


                int answer;
                string sql = "DELETE FROM Character WHERE CharacterID=@CID";


                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@CID", CharacterIDTextBox.Text);

                answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command

                MessageBox.Show("Successfully deleted " + answer + " Character");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open(); //Opens the connection to the database


                int answer;
                string sql = "INSERT INTO Inventory VALUES (@CID, @EID, @ADate, @LDate, @Status, @Slot)"; //The @s are placeholders. Telling system that they will be seen later in the code


                command = new SqlCommand(sql, connection);

                //Connects the correct textbox data with what attribute they will be put into
                command.Parameters.AddWithValue("@CID", CharacterIDTextBox.Text);
                command.Parameters.AddWithValue("@EID", EquipIDTxtBox.Text);
                command.Parameters.AddWithValue("@ADate", AcquireDateTxtBox.Text);
                command.Parameters.AddWithValue("@LDate", LossDateTxtBox.Text);
                command.Parameters.AddWithValue("@Status", StatusTxtBox.Text);
                command.Parameters.AddWithValue("@Slot", SlotTxtBox.Text);

                answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command

                MessageBox.Show("Successfully entered " + answer + " inventory item");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open(); //Opens the connection to the database


                    int answer;
                    string sql = "UPDATE Inventory SET CharacterID=@CID, EquipmentID=@EID, AcquireDate=@ADate, LossDate=@LDate, Status=@Status, Slot=@Slot WHERE InventoryID=@IID"; //The @s are placeholders. Telling system that they will be seen later in the code


                    command = new SqlCommand(sql, connection);

                    //Connects the correct textbox data with what attribute they will be put into
                    command.Parameters.AddWithValue("@CID", CharacterIDTextBox.Text);
                    command.Parameters.AddWithValue("@EID", EquipIDTxtBox.Text);
                    command.Parameters.AddWithValue("@ADate", AcquireDateTxtBox.Text);
                    command.Parameters.AddWithValue("@LDate", LossDateTxtBox.Text);
                    command.Parameters.AddWithValue("@Status", StatusTxtBox.Text);
                    command.Parameters.AddWithValue("@Slot", SlotTxtBox.Text);
                    command.Parameters.AddWithValue("@IID", dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command

                    MessageBox.Show("Successfully modified " + answer + " inventory item");
                }
                else
                {
                    MessageBox.Show("ERROR! Select a character's equipment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open(); //Opens the connection to the database


                    int answer;
                    string sql = "DELETE FROM Inventory WHERE InventoryID=@IID"; //The @s are placeholders. Telling system that they will be seen later in the code


                    command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@IID", dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command

                    MessageBox.Show("Successfully deleted " + answer + " inventory item");
                }
                else
                {
                    MessageBox.Show("ERROR! Select a character's equipment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear textboxes
                CharacterIDTextBox.Text = "";
                RaceTextBox.Text = "";
                PlayerTextBox.Text = "";
                ClassTextBox.Text = "";
                CharacterNameTextBox.Text = "";
                StrengthTextBox.Text = "";
                DexterityTextBox.Text = "";
                IntelligenceTextBox.Text = "";
                HitPointTextBox.Text = "";
                AcquireDateTxtBox.Text = "";
                LossDateTxtBox.Text = "";
                StatusTxtBox.Text = "";
                SlotTxtBox.Text = "";
                equipmentNameTxtBox.Text = "";
                EquipIDTxtBox.Text = "";
                TypeTxtBox.Text = "";
                SizeTxtBox.Text = "";
                RarityTxtBox.Text = "";

                //Clear listboxes
                lstEquip.Items.Clear();

                //Clear datagridview
                dataGridView1.DataSource = null;

                //Clear combobox
                cmbChar.SelectedIndex = -1;

                //Hide the averages panel
                avPanel.Visible = false;

                //Call the load form funtion so that changes made will show up
                Load_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (equipmentNameTxtBox.Text != "")
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open(); //Opens the connection to the database


                    int answer;
                    string sql = "INSERT INTO Equipment VALUES (@EName, @Type, @Size, @Rarity)"; //The @s are placeholders. Telling system that they will be seen later in the code


                    command = new SqlCommand(sql, connection);

                    //Connects the correct textbox data with what attribute they will be put into
                    //command.Parameters.AddWithValue("@EID", EquipIDTxtBox.Text);          Don't include this, it will automatically increment
                    command.Parameters.AddWithValue("@EName", equipmentNameTxtBox.Text);
                    command.Parameters.AddWithValue("@Type", TypeTxtBox.Text);
                    command.Parameters.AddWithValue("@Size", SizeTxtBox.Text);
                    command.Parameters.AddWithValue("@Rarity", RarityTxtBox.Text);

                    answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                    connection.Close(); //Closes the connection to the database. Don't want to leave it open
                    command.Dispose(); //Disposes of the command

                    MessageBox.Show("Successfully entered " + answer + " item into equpiment");
                }
                else
                {
                    MessageBox.Show("ERROR! Enter the name of the equipment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open(); //Opens the connection to the database


                int answer;
                string sql = "UPDATE Equipment SET EquipmentName=@EName, Type=@Type, Size=@Size, Rarity=@Rarity WHERE EquipmentID=@EID"; //The @s are placeholders. Telling system that they will be seen later in the code


                command = new SqlCommand(sql, connection);

                //Connects the correct textbox data with what attribute they will be put into
                command.Parameters.AddWithValue("@EName", equipmentNameTxtBox.Text);
                command.Parameters.AddWithValue("@Type", TypeTxtBox.Text);
                command.Parameters.AddWithValue("@Size", SizeTxtBox.Text);
                command.Parameters.AddWithValue("@Rarity", RarityTxtBox.Text);
                command.Parameters.AddWithValue("@EID", EquipIDTxtBox.Text);

                answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command

                MessageBox.Show("Successfully modified " + answer + " piece of equipment");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open(); //Opens the connection to the database


                int answer;
                string sql = "DELETE FROM Equipment WHERE EquipmentID=@EID"; //The @s are placeholders. Telling system that they will be seen later in the code


                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@EID", EquipIDTxtBox.Text);

                answer = command.ExecuteNonQuery(); //Loading rata to the database -- write to the database

                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command

                MessageBox.Show("Successfully deleted " + answer + " piece of equipment");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void showAvsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string strString = "SELECT AVG(1.0 * Strength) FROM Character";
                string dexString = "SELECT AVG(1.0 * Dexterity) FROM Character";
                string intString = "SELECT AVG(1.0 * Intelligence) FROM Character";
                string hpString = "SELECT AVG(1.0 * HitPoints) FROM Character";

                connection = new SqlConnection(connectionstring);


                //Load data for average str
                connection.Open(); //Opens the connection to the database
                command = new SqlCommand(strString, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    avStrengthTextBox.Text = datareader[0].ToString();
                }
                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command
                datareader.Close(); //Closes the datareader


                //Load data for average dex
                connection.Open(); //Opens the connection to the database
                command = new SqlCommand(dexString, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    avDexterityTextBox.Text = datareader[0].ToString();
                }
                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command
                datareader.Close(); //Closes the datareader


                //Load data for average int
                connection.Open(); //Opens the connection to the database
                command = new SqlCommand(intString, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    avIntelligenceTextBox.Text = datareader[0].ToString();
                }
                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command
                datareader.Close(); //Closes the datareader


                //Load data for average HP
                connection.Open(); //Opens the connection to the database
                command = new SqlCommand(hpString, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    avHitPointsTextBox.Text = datareader[0].ToString();
                }
                connection.Close(); //Closes the connection to the database. Don't want to leave it open
                command.Dispose(); //Disposes of the command
                datareader.Close(); //Closes the datareader


                //Show the panel
                avPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void hideAvsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Hide the panel
                avPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }
    }
}
