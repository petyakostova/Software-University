'''
Write a program that reads from the console number r and calculates
and prints the face and perimeter of a circle with radius r.
area = math.pi * r * r
perimeter = 2 * math.pi * r
'''

import math

r = float(input())

area = math.pi * r * r
perimeter = 2 * math.pi * r

print('Area = ' + str(area))
print('Perimeter = ' + str(perimeter))
