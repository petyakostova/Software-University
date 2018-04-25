'''
Write a program that reads degrees on the Celsius scale (°C)
and converts them to degrees Fahrenheit (°F).
Look for an appropriate formula on the Internet to make the calculations.
Round the score to 2 decimal places.
'''

celsius = float(input())
# °F = °C × 1,8 + 32
fahrenheit = celsius * 1.8 + 32

print("%.2f" % fahrenheit)
