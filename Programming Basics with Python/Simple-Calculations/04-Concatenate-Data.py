'''
Write a program that reads the name, surname, age and city of the console
and prints a message like this:
"You are <firstName> <lastName>, <old> -years old person from <town>.
'''
first_name = input()
last_name = input()
age = int(input())
town = input()

print('You are ' + first_name + ' ' + last_name
      + ', a ' + str(age) + '-years old person from ' + town + '.')

# second way
# print('You are %s %s, a %d-years old person from %s.'
#       % (first_name, last_name, age, town))

# third way
# print('You are ' + first_name + ' ' + last_name, end='')
# print(', a ' + str(age) + '-years old person from ' + town + '.')
