'''Write a console program that reads a positive N integer from the console
and prints a console square of N asterisks.'''

n = int(input())

print('*' * n)

for i in range(0, n - 2):
    print('*' + ' ' * (n - 2) + '*')

print('*' * n)
