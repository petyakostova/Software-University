'''
A rectangle is given with the coordinates of two of its opposite angles (x1, y1) - (x2, y2).
Calculate its area and perimeter.
The input is read from the console. The numbers x1, y1, x2 and y2 are given in one order.
The output is output to the console and must contain two rows with one number each - face (rounded to int) and perimeter (rounded floor). =>
'''
import math

x1 = float(input())
y1 = float(input())
x2 = float(input())
y2 = float(input())

a = abs(x1 - x2)
b = abs(y1 - y2)

area = a * b
area_to_int = int(area)

perimeter = 2 * (a + b)

print(area_to_int)
print(math.floor(perimeter))
