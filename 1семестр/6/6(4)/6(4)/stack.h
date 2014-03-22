#pragma once

struct Stack;
typedef int TypeOfElement;

//Cоздает стек
Stack *createStack();

//ЗАносит значение в стек
void push(Stack *stack, TypeOfElement element);

//Удаляет первый эдемент стека
void pop(Stack *stack);

//Возвращает первый элемент стека
TypeOfElement top(Stack *stack);

//Размер стека (количество элементов)
int size(Stack *stack);

//Удаляет стек
void deleteStack(Stack *stack);