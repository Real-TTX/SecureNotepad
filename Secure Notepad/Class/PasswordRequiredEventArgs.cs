using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNotepad.Assets
{
    public class PasswordRequiredEventArgs : EventArgs
    {

        public bool Confirmation;

        public bool Cancel;

    }

}
