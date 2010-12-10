
require ../lib/test-more.fs
require ../lib/list.fs

38 plan

{sp

diag" Testing list\n"

4 5 6 3 ldup 4 5 6 3 4 5 6 3 8 =deeply" list dup"         ?sp
      0 ldup             0 0 2 =deeply" empty list dup"   ?sp

4 5 6 3 7 8 9 3 ldrop 4 5 6 3 4 =deeply" list drop"       ?sp
      0       0 ldrop       0 1 =deeply" empty list drop" ?sp

0 \ Empty list
100 >list    100 1 2 =deeply" append to empty list"       ?sp

100 1      \ Initial list
\ Append 200
200 >list    100 200 2 3 =deeply" list append"            ?sp


100 200 2 list>        200          =ok" removed item"
                       100 1 2  =deeply" remaining items" ?sp

100 1     list>        100          =ok" removed item"
                       0 1      =deeply" remaining items" ?sp

:noname 0 list> ; 
  list-empty-exception throw-ok" empty exception" ?sp

\ lzip

:noname 0 1 1 lzip ; 
  list-size-exception throw-ok" size exception" ?sp

\ test-bad-size ?sp

      0 0 lzip             0 1 =deeply" zip empty lists"     ?sp
10 1 20 1 lzip       10 20 2 3 =deeply" zip single el lists" ?sp
  10 11 2
  20 21 2 lzip 10 20 11 21 4 5 =deeply" zip two el lists"    ?sp

13 14 15 3 ldup lzip
  13 13 14 14 15 15 6 7 =deeply" ldup, lzip" ?sp

13 14 15 3 20 21 2 1 lroll
  20 21 2 13 14 15 3 7 =deeply" lroll" ?sp

20 21 2 13 14 15 3 1 lroll
  13 14 15 3 20 21 2 7 =deeply" lroll 2" ?sp

10 1 20 21 2 30 31 32 3 2 lroll
  20 21 2 30 31 32 3 10 1 9 =deeply" lroll 3" ?sp

13 14 15 3 20 21 2 lswap
  20 21 2 13 14 15 3 7 =deeply" lswap" ?sp

}sp

bye
