n = int(input())

print('*' * n)

for i in range(0, n - 2):
    print('*' + ' ' * (n - 2) + '*')

print('*' * n)
