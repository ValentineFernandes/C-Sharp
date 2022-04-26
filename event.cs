using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
 
namespace eventdemo {
   public partial class treeviewdemo : System.Web.UI.Page {
   
      protected void Page_Load(object sender, EventArgs e) { 
         txtmessage.Text = " "; 
      }
      
      protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e) {
      
         txtmessage.Text = " "; 
         lblmessage.Text = "Selected node changed to: " + TreeView1.SelectedNode.Text;
         TreeNodeCollection childnodes = TreeView1.SelectedNode.ChildNodes;
         
         if(childnodes != null) {
            txtmessage.Text = " ";
            
            foreach (TreeNode t in childnodes) {
               txtmessage.Text += t.Value;
            }
         }
      }
   }
}
