'''
Write a program that reads from the console 3 real numbers b1, b2 and h
and calculates the face of trapezoid with bases b1 and b2 and height h.
The trapezoidal face formula is (b1 + b2) * h / 2.
'''

a = float(input())
b = float(input())
h = float(input())

area = (a + b) * h / 2
print(area)
