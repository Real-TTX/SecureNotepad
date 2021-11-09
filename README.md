# SecureNotepad

SecureNotepad (notepads.exe) is a minified and simplified notepad for windows. Its like the big brother of windows built in notepad.exe.


# Install

1. Download latest archive and unpack binaries (notepads.exe) to system32 folder.

2. Register extension (.txts) by running the following command as administrator (Running CMD as administrator)
  FTYPE SecureTextfile=%SystemRoot%\system32\notepads.exe "%1"
  ASSOC .txts=SecureTextfile
