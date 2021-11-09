using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNotepad
{

    public class Document
    {

        public event EventHandler DocumentLoaded;

        public event EventHandler<PasswordRequiredEventArgs> PasswordRequired;

        public event EventHandler DocumentSaved;

        public event EventHandler DocumentSaveFileRequired;


        private string mFile;
        private string mFileContent;

        private string mPassword;

        private bool mPendingChanges;
        private bool mIsSecure;

        public Document()
        {


        }


        public string File
        {
            get
            {
                return this.mFile;
            }
            set
            {
                this.mFile = value;
            }
        }


        public bool IsSecure
        {
            get
            {
                return this.mIsSecure;
            }
        }


        public string FileContent
        {
            get
            {
                return this.mFileContent;
            }
            set
            {
                this.mFileContent = value;
                this.mPendingChanges = true;
            }
        }

        public string Password
        {
            get
            {
                return this.mPassword;
            }
            set
            {
                this.mPassword = value;
            }
        }

        public bool PendingChanges
        {
            get
            {
                return this.mPendingChanges;
            }
            set
            {
                this.mPendingChanges = value;
            }
        }

        public void SetPassword()
        {

            if (String.IsNullOrEmpty(this.mFile))
            {
                OnDocumentSaveFileRequired(new EventArgs());
            }
            if (String.IsNullOrEmpty(this.mFile))
            {
                return;
            }

            if (System.IO.Path.GetExtension(this.mFile).ToLower() != ".txts")
            {
                throw new ArgumentOutOfRangeException();
            }

            this.mPassword = "";
            if (String.IsNullOrEmpty(this.mPassword))
            {
                OnPasswordRequired(new PasswordRequiredEventArgs() { Confirmation = true });
            }

            string lTemp;

            lTemp = StringCipher.Encrypt("#SecureNotepad#" + Environment.NewLine + this.mFileContent, this.mPassword);

            System.IO.File.WriteAllText(this.mFile, lTemp);

            this.mPendingChanges = false;
            this.mIsSecure = true;
            OnDocumentSaved(new EventArgs());

        }


        public void Load(string File)
        {

            this.mFile = File;
            this.mIsSecure = false;

            if (!System.IO.File.Exists(this.mFile))
            {
                return;
            }

            this.mFileContent = "";
            this.mPendingChanges = false;

            switch (System.IO.Path.GetExtension(this.mFile).ToLower())
            {
                case ".txt":

                    this.mFileContent = System.IO.File.ReadAllText(this.mFile);
                    this.mPassword = "";

                    OnDocumentLoaded(new EventArgs());


                    break;


                case ".txts":

                    this.mFileContent = String.Empty;

                    PasswordRequiredEventArgs lPasswordRequiredEventArgs;
                    bool lSuccess;

                    lPasswordRequiredEventArgs = new PasswordRequiredEventArgs() { Confirmation = false };

                    do
                    {

                        lSuccess = false;

                        if (String.IsNullOrEmpty(this.mPassword))
                        {
                            OnPasswordRequired(lPasswordRequiredEventArgs);
                        }

                        string lTemp;
                        string lResult;
                        string lFirstLine;

                        try
                        {

                            lTemp = StringCipher.Decrypt(System.IO.File.ReadAllText(this.mFile), this.mPassword);

                            using (System.IO.StringReader reader = new System.IO.StringReader(lTemp))
                            {

                                lFirstLine = reader.ReadLine();
                                lResult = reader.ReadToEnd();

                                if (lFirstLine == "#SecureNotepad#")
                                {
                                    this.mFileContent = lResult;
                                    lSuccess = true;
                                    OnDocumentLoaded(new EventArgs());
                                    this.mIsSecure = true;
                                }
                                else
                                {
                                    this.mPassword = "";
                                }

                            }


                        }
                        catch (Exception ex)
                        {
                            this.mPassword = "";
                        }



                    } while (!(lPasswordRequiredEventArgs.Cancel || lSuccess));

                    if (!lSuccess)
                    {
                        this.mFileContent = "";
                        this.mFile = "";
                        OnDocumentLoaded(new EventArgs());
                    }

                    break;

            }


        }

        public void Save()
        {

            if (String.IsNullOrEmpty(this.mFile))
            {
                OnDocumentSaveFileRequired(new EventArgs());
            }
            if (String.IsNullOrEmpty(this.mFile))
            {
                return;
            }

            switch (System.IO.Path.GetExtension(this.mFile).ToLower())
            {

                case ".txt":

                    System.IO.File.WriteAllText(this.mFile, this.mFileContent);

                    this.mPendingChanges = false;
                    this.mIsSecure = false;
                    OnDocumentSaved(new EventArgs());

                    break;


                case ".txts":

                    if (String.IsNullOrEmpty(this.mPassword))
                    {
                        OnPasswordRequired(new PasswordRequiredEventArgs() { Confirmation = true });
                    }

                    string lTemp;

                    lTemp = StringCipher.Encrypt("#SecureNotepad#" + Environment.NewLine + this.mFileContent, this.mPassword);

                    System.IO.File.WriteAllText(this.mFile, lTemp);

                    this.mPendingChanges = false;
                    this.mIsSecure = true;
                    OnDocumentSaved(new EventArgs());

                    break;

            }

        }


        protected virtual void OnDocumentLoaded(EventArgs e)
        {
            EventHandler handler = DocumentLoaded;
            handler?.Invoke(this, e);
        }

        protected virtual void OnPasswordRequired(PasswordRequiredEventArgs e)
        {
            EventHandler<PasswordRequiredEventArgs> handler = PasswordRequired;
            handler?.Invoke(this, e);
        }

        protected virtual void OnDocumentSaved(EventArgs e)
        {
            EventHandler handler = DocumentSaved;
            handler?.Invoke(this, e);
        }

        protected virtual void OnDocumentSaveFileRequired(EventArgs e)
        {
            EventHandler handler = DocumentSaveFileRequired;
            handler?.Invoke(this, e);
        }


    }

}
