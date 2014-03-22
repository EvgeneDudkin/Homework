#pragma once

struct Stack;
typedef int TypeOfElement;

//C������ ����
Stack *createStack();

//������� �������� � ����
void push(Stack *stack, TypeOfElement element);

//������� ������ ������� �����
void pop(Stack *stack);

//���������� ������ ������� �����
TypeOfElement top(Stack *stack);

//������ ����� (���������� ���������)
int size(Stack *stack);

//������� ����
void deleteStack(Stack *stack);