﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class Model
    {
        public string CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int screenHeight = Console.WindowHeight;

            string[] lines = text.Split(new[] {Environment.NewLine}, StringSplitOptions.None);

            int verticalStart = (screenHeight - lines.Length) / 2;
            int horizontalStart = (screenWidth - lines[0].Length) / 2;

            StringBuilder centered = new StringBuilder();

            foreach (string line in lines)
            {
                centered.Append(line.PadLeft(horizontalStart + line.Length / 2));
            }

            return centered.ToString();
        }
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