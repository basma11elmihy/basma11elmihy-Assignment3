Stack and Heap Memory in C#

Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;

First line:

+---------------- STACK ----------------+    +---------------- HEAP ----------------+
|                                      |    |                                      |
| o1                                   |    | Order object                        |
| ┌───────────────┐                    |    | ┌──────────────────────────────────┐ |
| │ reference ─────────────────────────────>│ OrderId = 1                       │ |
| └───────────────┘                    |    | │ CustomerName = "Ali"              │ |
|                                      |    | │ IsPaid = false                    │ |
|                                      |    | │ ...                                │ |
|                                      |    | └──────────────────────────────────┘ |
+--------------------------------------+    +--------------------------------------+

o1 is a reference variable, and it points to the Order object created on the heap.

Second Line:
----------- STACK ----------------+    +---------------- HEAP ----------------+
|                                      |    |                                      |
| o1 ──────────────────────────────────────>│ Order object                        │
|                                      |    | ┌──────────────────────────────────┐ |
| o2 ──────────────────────────────────────>│ │ OrderId = 1                       │ |
|                                      |    | │ CustomerName = "Ali"              │ |
|                                      |    | │ IsPaid = false                    │ |
|                                      |    | │ ...                                │ |
|                                      |    | └──────────────────────────────────┘ |
+--------------------------------------+    +--------------------------------------+

o2 = o1 copies the reference, not the entire Order object. Therefore, o1 and o2 point to the same object on the heap.

Third Line:

+---------------- STACK ----------------+    +---------------- HEAP ----------------+
|                                      |    |                                      |
| o1 ──────────────────────────────────────>│ Order object                        │
|                                      |    | ┌──────────────────────────────────┐ |
| o2 ──────────────────────────────────────>│ │ OrderId = 1                       │ |
|                                      |    | │ CustomerName = "Ali"              │ |
|                                      |    | │ IsPaid = true  <-- changed         │ |
|                                      |    | │ ...                                │ |
|                                      |    | └──────────────────────────────────┘ |
+--------------------------------------+    +--------------------------------------+

Because o1 and o2 refer to the same heap object, changing IsPaid through o2 also means that o1 sees IsPaid as true.


************************************************************
What would be different with Structs?
When using structs instead of classes, the behavior would be different because structs are value types, 
while classes are reference types.

So if order was a struct instead of a class, the assignment o2 = o1 would create a copy of the entire Order struct.
that will make each one an indivdual copy of the data. .
Therefore, changing IsPaid in o2 would not affect o1, and they would have independent values.