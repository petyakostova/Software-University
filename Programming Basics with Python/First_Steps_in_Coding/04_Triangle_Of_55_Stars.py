'''
Write a Python console program that prints a triangle of 55 asterisks located in 10 rows:
*
**
***
****
*****
******
*******
********
*********
**********

'''

for i in range(1,11):
    print('*'*i)

'''
for i in range(1, 11):
    for j in range(0, i):
        print('*', end="")
    print()
'''