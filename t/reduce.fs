
require ../lib/test-more.fs
require ../lib/reduce.fs

21 plan

{sp

diag" Testing reduce\n"

 1  2  4    3 ' or reduce     7 =ok" reduce/or"        ?sp
                             
            0 nmin                                     ?sp
       1    1 nmin            1 =ok" nmin, 1 number"   ?sp
                             
 1  2  3    3 nmin            1 =ok" nmin, 3"          ?sp
 3  1  2    3 nmin            1 =ok" nmin, 3"          ?sp
 2  3  1    3 nmin            1 =ok" nmin, 3"          ?sp
                                                
 1  2  3    3 nmax            3 =ok" nmax, 3"          ?sp
 3  1  2    3 nmax            3 =ok" nmax, 3"          ?sp
 2  3  1    3 nmax            3 =ok" nmax, 3"          ?sp
                                                
10 20 30    3 nsum           60 =ok" nsum"             ?sp
10 20 30    3 nprod        6000 =ok" nprod"            ?sp

}sp

bye
