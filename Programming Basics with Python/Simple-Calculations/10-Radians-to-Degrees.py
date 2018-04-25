'''
Write a program that reads an angle in radians (rad)
and converts it into degrees (deg).
Look for an appropriate formula online.
The number π in Python programs is available through math.pi.
Round the result to the nearest integer using round().
'''
import math
angle_in_radians = float(input())
''' α(degrees) = α(radians) × 180° / π
The angle α in degrees is equal to the angle α in radians times 180 degrees divided by pi constant'''
angle_in_degrees = angle_in_radians * 180 / math.pi

print(round(angle_in_degrees))
