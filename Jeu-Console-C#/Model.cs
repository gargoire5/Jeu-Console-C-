﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class Model
    {
        public string menu = @"
 _____         _     __  __                 
|_   _|__  ___| |__ |  \/  | ___  _ __  ___ 
  | |/ _ \/ __| '_ \| |\/| |/ _ \| '_ \/ __|
  | |  __/ (__| | | | |  | | (_) | | | \__ \
  |_|\___|\___|_| |_|_|  |_|\___/|_| |_|___/



              [P]lay      [Q]uit

";
        public string dingus = @"                            
                                                                                       +#               
                                                                         .-++------+####.               
                                 .--+#####+-    -####+.           -####################-                
                            -#########################################################+                 
                        .+############################################################                  
                     +################################################################                  
                   ###################################################################-                 
                 ######################################################################                 
                ##################################################################+####+                
               #################################################+++##############+++####                
              ##################################################+###-+########++--+#####+               
             +###########################################################################               
            +############################################################################               
            ########################################################################+++++               
           -############################################++++-..--++##############-.    .                
           +#######################################++######+++-...-++############+-    .                
           +########################################+++++++-+-.--..-+######++####-     .                
           +##########################################++#+++###+-.  ..........         .                
           -########################################+##+####+##+--................     -                
           .#######################################+##+########+-   ............       -                
            ###################################################++.                    ..                
            ####################################################+.                   .+                 
            -###################################################+.                   .+                 
             #####################################################+.                 .+                 
             -#####################################################+-               .++                 
              #######################################################+.            .+#                  
               +#######################################################-        ..+##-                  
                +########################################################-   .+##+###                   
                  .######################################################+.  .######-                   
                      +#################################################+-   .#####+                    
                          .-############################################-    .####-                     
                                -########################################-   .###+                      
                                     -####################################+..+#-                        
                                         ##################################-                            
                                            +############################                               
                                                 +######################                                
                                                       .---+++######+.                                  
    ";

        public string map = @"
                                                                                                   
 @@@@ @@       @: @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @               @ @@@@@@@@@@@@@@@@@@@@@=*#=: :@ 
 @ @@          #  @@@  @@@@@@@@                  @ @               @ @     @@  @ @@@@@@@@        : 
 @ @@ @@@@@@@@%   @@* @@    @ @ %                @ @               @ @  @  @@@@@          @@@      
 @ @@                @@ @@@@@ @                  @ @  -            @ @   %@@@-   %   @ =@@@ @      
 @ @@                @@@    @ @ @@@@@ @@@@@@     @ @  :            @ @ @@@    @@@@@@@@@   @@ @     
 @ @@       -%-      @@@    @@@ @@@@@       =    @ @               @ @ @ @    @@     @@    @=@     
 @ @-            @@   @@    @@@@*@ @@ @@@@@@  @@@@ @               @ @ @ @ #@ @@@@@@@@@ :- :     : 
 @ @# @@#@@@@@@@@@@@@ @@    @ @@@@@@@@         @@@- @    ::  #@     @:@ @:@        : @      @@=   : 
 @ @@           @@@@ @@@    @@@ @@@@@         @@@@ @               @ @ @@@    @@    %@ @   @ @   - 
 @ @     :--==* @@@@ @ @    @ @@@  @@@@@@     @@@@ @    #@#@@@#    @ @  @@@  @@@@@@@@@ @   @ @   - 
 @ @                 @ @    @ @ @  @   @@        @ @               @ @  @@@ @         %@   @ @   - 
 @ @                 @@@    @@@@@  @@@@ @        @ @               @ @  @ @ @@@@@@@@@@#    @ @   = 
 @ @                 @@@     @@@@@@@ @ @ @@@@@@ @ @               @ @  @ @     # @@@@%    @%    = 
 @ @       Salle     @@@     @@       @ @      @ @ @               @ @  @ @     @@    @@   @@      
 @ @        Hedy     @@@     @ @@@@@@:@ @ @@@@@@ @ @               @ @  @ @      @@@@@ @   @@@     
 @ @       Lamarr    @ @     @@@@     @ @        @ @               @ @  @ @     @@   @ @   @ @ @@@ 
 @ @                 @ @     @@@@ %#- @ @     @@ @@@               @@@  @@@     @@@@ @%@ - @ @ @@@ 
 @ @                 @ @     @ @@      @@     @  @@@               @@@  @@@      *   @@@ @ @ @ @%@ 
 @ @                 @@@     @*       @@-   - @@@    @%#=: :--==- @%        =-=-           @ @ @@@ 
 @ @                 @       @@   @@@@@@@                         @@@                      @@@     
 @ @                 @@@     @@   @@@@@@@ @@@ @ @                 @ @              @@@@@@  @@-   = 
 @ @                 @ @     @@   @@@@ @@     @ @                 @ @              @@  @@    @   = 
 @ @                 @@@     @@ @-@@ @@@@     @ @                 @ @              @@@@@@  #@:   # 
 @ @@@@@@@@@@@@@@@@@@@ @     @@@@@  @@@ @@@@@@@ @                 @ @                      @@@   % 
 @ @@@@@@@@@@@@@@@@@@@ @     @@  @* @@ @ @     : @                @ @                      @*@   # 
 @@@@@@@@@@@@@@@@@@@@@ @     @@@@@@@@@@@@@@@@@@ @                 @ @        *@@@@@@       @@@   * 
 @ @                 @@@     @      -   @@ @@ @ @                 @ @        @     @       @@@   % 
 @ @                 @@@     @@ =@@ @@@@@@% @ @ @                 @ @        =@@@@@@       @@-   - 
 @ @                 @@@     @@ @%@ @ @@ @@=@ @ @                 @ @                      @@      
 @ @                 @@@     @@ @  @@@@@@@ @@ @ @                 @ @                      @@ #    
 @ @                 @@@     @@   @@@@@@@  @@ @ @                 @ @                      @@      
 @ @                 @@@     @-@ -@ @   @ @   @ @                 @ @              @@@@@@   @@     
 @ @                 @@@     @ @ @@ @@@@   @@ @ @                 @ @              @@  @@    @   * 
 @ @                 @@@     @:@  @@@   @ @  @@ @                 @ @              @@@@@@   @@   # 
 @ @                 @ @     @@ @@   *@#@ @@# @ @       =-        @ @                      @@ @  # 
 @@@@@@@@@@@@@@@@@@@@@ @     @@   @@@         @ @                 @ @                      @@ #    
 @@@@@@@@@@@@@@@@@@@@@@@     @@@@#@ @@@-@@@@@@@ @@@@@@@@@@@@@@@@@@@ @                   @@@@@@@@*@ 
 @@@@@@@@@@@@@@@@@@@@@@@     @@@@@@ @@@@@@@@@@@ @@@@@@@@@@@@@@@@@@@ @@                  @@@   @@ @ 
 @ @@@@@@@@@@@@@@@@@@@@%                                            @@                  @@@@@@@@ @ 
 @ @@@@@@@@@@@@@@@@@@@@@                                            @@                    @@@@@@@@ 
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  @@@@@@@@  @@  @@@@@ @@                    @ @@ @ @ 
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  @@@@@@@@@ @@  @@@@@@ @                    @ @@@@@@ 
 @ @                                                   @ @        @ @                    @@  @@@@ 
 @ @                                                   @@ @        @ @                     @  @@@@ 
 @ @                                                   @@ @        @ @             @@@@@@@ @ @     
 @ @                                                   @@ @        @ @            :        @ @   % 
 @ @                                                   @@ @        @ @             @@@@@@@ :@ @  * 
 @ @                   Salle Mario                     @@ @        @ @                      @ @  * 
 @ @                                                   @@ @        @ @                      @ @    
 @ @                                                   @@ @        @ @                       @%@   
 @ @                                                   %@ @        @ @                       @ @   
 @ @                                                   =@ @        @ @                       @ @   
 @ @                                                    @ @        @ @                             
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@ 
                                                                                                   
";

        public string mario = @"
                                      Salle Mario 
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   @@@@@@@@@@
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ||     ||       ||     ||  @@@           @@@@
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ||     ||       ||     ||  @@@           @@@@
 @ @                                       ||     ||       ||     ||  @@@           @@@@
 @ @                                       ||     ||       ||     ||  @@@           @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                                                                @@@@
 @ @                                                                                @@@@
 @ @                                                                                @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                       ||     ||       ||     ||                @@@@ 
 @ @                                       ||     ||       ||     ||                @@@@ 
 @ @                                       ||     ||       ||     ||                @@@@ 
 @ @                                       ||     ||       ||     ||                @@@@ 
 @ @                                       ||     ||       ||     ||                @@@@ 
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @                                       ||     ||       ||     ||                @@@@
 @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
";
    }
}