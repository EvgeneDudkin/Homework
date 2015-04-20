//1)Функция ,которая работает как map, только для каждого значения исходного списка можно задать не одно, а несколько значений, на которые его надо заменить
let supermap list mapFunction = 
    let rec supermapHelperFunc ((list :'a list), (mapFunction : 'a -> 'b list), (acc : 'b list)) =
        match list with
        |head::tail -> supermapHelperFunc(tail,mapFunction,acc @ mapFunction head)       
        |[]-> acc
    supermapHelperFunc(list,mapFunction,[]) 


//Пример работы функции 
supermap [10;20;30] (fun x -> [2*x,3*x])


//3) Хеш-таблица
type HashTable (func : int -> int) =
    let mutable arrayOfLists = Array.create 100 []
    member t.InTable(x:int) = List.exists(fun y->y=x) arrayOfLists.[func x % 100]
    member t.insert(x) = arrayOfLists.[func x % 100] <- x::arrayOfLists.[func x % 100]
    member t.delete(x) = arrayOfLists.[func x % 100] <- List.filter (fun y -> y <> x) arrayOfLists.[func x % 100]

let t = new HashTable(fun x->x*x)

t.insert(10);;
t.InTable(10);;

