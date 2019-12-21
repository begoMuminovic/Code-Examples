using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

public partial class mywork_Student : System.Web.UI.Page
{

    AdvisingDBEntities dbcon = new AdvisingDBEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentTable tempStudent = dbcon.StudentTables.First();
        int advisorID = tempStudent.StudentAdvisorID;
        AdvisorTable tempAdvisor = new AdvisorTable();
        Label3.Text = tempAdvisor.AdvisorFirstName + tempAdvisor.AdvisorLastName;
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int temp = GridView1.SelectedIndex;
        AdvisingDBEntities dbcon = new AdvisingDBEntities();
        (from x in dbcon.EmailTables
         where x.MSG_ID == temp
         select x).First();

        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (AdvisingDBEntities dbcon = new AdvisingDBEntities())
        {
            EmailTable abc = new EmailTable();
            abc.MSGdate = DateTime.Now;
            abc.MSGtext = TextBox2.Text;

            dbcon.EmailTables.Add(abc);
            Page page = this.Page;
            MessageBox.Show(page, "Message Sent");

            dbcon.SaveChanges();

        }
    }
   
}
public static class MessageBox
{
    public static void Show(this Page Page, String Message)
    {
        Page.ClientScript.RegisterStartupScript(
           Page.GetType(),
           "MessageBox",
           "<script language='javascript'>alert('" + Message + "');</script>"
        );
    }
}