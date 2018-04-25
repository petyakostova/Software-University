'''
Write a program for converting money from one currency to another.
The following currencies need to be maintained: BGN, USD, EUR, GBP.
Use the following fixed exchange rates:
Course      USD         EUR         GBP
1 BGN       1.79549     1.95583     2.53405
The input is a Conversion Amount + Input Currency + Output Currency.
The output is one number - the converted amount on the above courses,
 rounded to 2 digits after the decimal point.
'''

amount = float(input())
input_currency = input()
output_currency = input()

usd = 1.79549
eur = 1.95583
gbp = 2.53405

# Convert money in BGN
if input_currency == 'USD':
    amount *= usd
elif input_currency == 'EUR':
    amount *= eur
elif input_currency == 'GBP':
    amount *= gbp

# Convert to wanted currency
if output_currency == 'USD':
    amount /= usd
elif output_currency == 'EUR':
    amount /= eur
elif output_currency == 'GBP':
    amount /= gbp

print(f'{amount:.2f} {output_currency}')
