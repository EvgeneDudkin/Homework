#include "stack.h"

struct ElementOfStack
{
	TypeOfElement element;
	ElementOfStack *next;
};

struct Stack
{
	ElementOfStack *head;
	int size;
};

Stack *createStack()
{
	Stack *newStack = new Stack;
	newStack->size = 0;
	newStack->head = nullptr;
	return newStack;
}

void push(Stack *stack, TypeOfElement element)
{
	ElementOfStack *newElement = new ElementOfStack;
	newElement->element = element;
	newElement->next = stack->head;
	stack->head = newElement;
	stack->size++;
}

void pop(Stack *stack)
{
	ElementOfStack *temp = stack->head;
	stack->head = stack->head->next;
	delete temp;
	stack->size--;
}

TypeOfElement top(Stack *stack)
{
	return stack->head->element;
}

int size(Stack *stack)
{
	return stack->size;
}

void deleteStack(Stack *stack)
{
	ElementOfStack *temp = stack->head;
	while (temp != nullptr)
	{
		ElementOfStack *tempForDelete = temp;
		temp = temp->next;
		delete tempForDelete;
	}
	delete stack;
}