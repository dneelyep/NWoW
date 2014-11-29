using System.Windows.Forms;
using NWoW;

namespace NWoWClient
{
    /// <summary>
    /// A simple class to allow testing the NWoW API.
    /// </summary>
    public partial class frmNWoWClient : Form
    {
        public frmNWoWClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Use the current UI state to get an object of the requested type,
        /// with the requested parameters, etc.
        /// </summary>
        private void GetObject()
        {
            string strCharacterName = tbCharacterName.Text;
            string strServer = cbServer.Text;

            Character requestedCharacter = Requests.GetCharacter(strServer, strCharacterName);
        }

 #region "Events"
        private void btnGetObject_Click(object sender, System.EventArgs e)
        {
            GetObject();
        }
 #endregion
    }
}
