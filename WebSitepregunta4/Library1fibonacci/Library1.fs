namespace Library1fibonacci

module fibonacci =
    let fiboestr (n:int) = 
        let mutable a=(-1)
        let mutable b=1
        let mutable c=0
        let mutable d=0
        for i in 1..(n-1) do
            a<-b
            b<-c
            c<-d
            d<-a+b+c
        d
    
    let fibonacci_estr(n:int) =
        let mutable r=""
        for i in 1..n do
            r<- r + string (fiboestr i) + " , "
        r

    let rec fibrec(n: int):int = 
        match n with
        | 0 -> 0
        | 1 -> 0
        | 2 -> 1
        | n -> fibrec (n-1) + fibrec (n-2) + fibrec(n-3)

    let fibonacci_rec(x:int) =
        let mutable r=""
        for i in 1 .. x do
            r<- r + string (fibrec i) + " , "
        r

type Class1() = 
    member this.X = "F#"
