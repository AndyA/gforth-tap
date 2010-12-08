: reduce ( n ... n xc -- n ) recursive
    over 2 < if
        2drop
    else
        dup >r ( save xt for word to execute )
        swap 1- swap reduce ( recurse )
        r> execute ( execute word on remaining two values )
    then
;

: nmin ( n ... n -- n )
    ['] min reduce
;

: nmax ( n ... n -- n )
    ['] max reduce
;

: nsum ( n ... n -- n )
    ['] + reduce
;

: nprod ( n ... n -- n )
    ['] * reduce
;
