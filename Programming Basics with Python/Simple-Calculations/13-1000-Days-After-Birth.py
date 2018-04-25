'''
Write a program that enters the birthday date in dd-MM-yyyy format
and calculates the date 1000 days of that birth date
and prints it in the same format.
Input           Output
25-02-1995      20-11-1997
07-11-2003      02-08-2006
30-12-2002      24-09-2005
01-01-2012      26-09-2014
14-06-1980      10-03-1983
'''
# https://docs.python.org/3/library/datetime.html

# from datetime import *
from datetime import date, timedelta

day, month, year = input().split('-')

''' class datetime.date => An idealized naive date, assuming the current 
Gregorian calendar always was, and always will be, in effect.
Attributes: year, month, and day.'''
input_date = date(int(year), int(month), int(day))

''' class datetime.timedelta => A duration expressing the difference between 
two date, time, or datetime instances to microsecond resolution.'''
hundred_years = timedelta(days=999)
future_date = input_date + hundred_years

''' date.strftime(format) => Return a string representing the date, 
controlled by an explicit format string. 
Format codes referring to hours, minutes or seconds will see 0 values. 
'''
print(future_date.strftime('%d-%m-%Y'))
