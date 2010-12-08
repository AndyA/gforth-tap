\ Stack based lists. Just for fun

\ Add a value to the front of a list
: >list ( n0 ... nn u n -- n0 ... nn u )
  swap 1+
;

\ Make our exception objects
s" List empty"        exception Constant list-empty-exception
s" List sizes differ" exception Constant list-size-exception

\ Remove a value from the front of a list
: list> ( n0 ... nn u -- n0 ... nn u n )
  dup 0= list-empty-exception and throw
  1- swap
;

\ Duplicate a list
: ldup ( n0 ... nn u -- n0 ... nn u n0 ... nn u )
  dup dup 0 ?do
    dup 1+ pick swap
  loop
;

\ Drop a list
: ldrop ( n0 ... nn u -- )
  0 ?do
    drop
  loop
;

: lzip-loop { hi lo }
  hi 1+ lo ?do
    hi roll i roll      \ Damn poetry!
  loop
;

\ Zip two identically sized lists together
: lzip ( n0 ... nn u m0 ... mn u -- n0 ... nn u )
  dup dup 1+ 1+ pick <> list-size-exception and throw
  dup dup 2* 1+ swap 1+ lzip-loop
  +
;
