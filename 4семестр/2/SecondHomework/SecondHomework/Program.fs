//Функция, которая "разворачивает" список
let reverse list = 
    let rec reverseHelpFunction tail acc = 
        match tail with 
        |h::t -> 
            reverseHelpFunction t (h::acc)
        |[] -> acc
    reverseHelpFunction list []

//Пример работы функции reverse
let list = reverse [1;2;3]

//Функция, которая создает список с х последовательными степенями двойки
let rec degreeList x =
    if x = 0 then [1]
    else 
        let acc = x-1 |> degreeList
        match acc with
        |h::t -> (h*2)::acc
        |[] -> []

//Пример работы функции degreeList
let list1 = 5 |> degreeList |> reverse

//Функция, которая считает произведение цифр числа 
let multiFunction x =
    let rec multiHelperFunction x acc =
         if (x < 10) then acc*x
         else 
            let p = x / 10
            let s = x % 10
            multiHelperFunction p (s*acc)
    multiHelperFunction x 1

//Пример работы multiFunction        
multiFunction 23221

//Функция, которая находит первое вхождение числа в список
let findElement list x =
    let rec findHelper list' acc =
        match list' with 
        |h::t -> 
            if h = x then  Some acc
            else findHelper t (acc+1)
        |[]-> 
            printfn "Does not exist"
            None
    findHelper list 1

//Пример работы функции findElement
findElement [1;1;2;3;4] 2

//Функция, которая проверяет строку на полиндром
let polindrom (x : string) = 
    let step = () |> x.ToCharArray |> Array.toList
    let test = reverse step
    if (step = test ) then printfn "ok"
    else printfn "not ok"

//Пример работы функции polindrom
polindrom "ololol"
polindrom "ololo"