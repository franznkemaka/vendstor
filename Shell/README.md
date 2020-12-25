

#### Shell Commands
# Main : 
- install, ins, i
- update, upd, u
- uninstall, uni,
- delete, del, d
- remove, rm, r
- download, dl
- extract, ext, e

## Alias Parameters : 

#General 

-p : Path
-n : Name
-v : Version

#Registry
-disname, -name : Display Name
-v : Display Version
-disicon : Display Icon
-pub : Publisher
-helplink : Help Link
-helptel : Help Telephone
-insdate : Install Date
-insloc : Install Location
-inssrc : Install Source
-urlinfo : Url Info
-urlupdinfo: Url Update Info
-comments : Comments
-essize : Estimated Size
-lang : Language
-modifyp : Modify Path
-readme : Read Me
-uninsstr : UninstallString
-setsid : Settings Identifier



# Demos

shell install -name "Testing App Shell" -v "0.0.1" -disicon "P:\C#\dev\Test\logo.ico" -pub "RigleSoft Testing" -helplink "www.riglesoft.com" -urlinfo "support.riglesoft.com" -uninsstr "P:\C#\dev\Test\uninstall.exe" -insloc "P:\C#\dev\Test" -comments "Testing Comments" -readme "Readme Testing" -lang "de, en, fr, all" -akn "Testing App Shell"

shell install -update "Testing App Shell" -v "0.0.2" -akn "Testing App Shell"



