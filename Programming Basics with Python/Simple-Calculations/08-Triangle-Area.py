'''
Write a program that reads from the console side and triangle height
and calculates its face.
Use the face to triangle formula: area = a * h / 2.
Round the result to 2 decimal places using
float("{0:.2f}".format (area))
'''

a = float(input())
h = float(input())

area = a * h / 2;

print("{0:.2f}".format(area))
