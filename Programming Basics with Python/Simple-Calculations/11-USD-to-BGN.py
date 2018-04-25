'''
Write a program to convert US Dollars (USD) into Bulgarian Leva (BGN).
Round the result to 2 digits after the decimal point.
Use a fixed exchange rate between USD and BGN: 1 USD = 1.79549 BGN.
'''

usd = float(input())

bgn = usd * 1.79549

print("%.2f" % bgn)
