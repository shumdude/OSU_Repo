import math

DEBUG = False
input_values = input()

values_list = [int(value) for value in input_values.split(";")]
values_list.sort()  # Все числа должны быть выведены в порядке возрастания
if DEBUG: print(values_list)
values_set = set(values_list)  # без повторений
if DEBUG: print(values_set)

for value in values_set:
    text = f"{value} - "
    num_list = list()
    for index, num in enumerate(values_set):
        if num == value:
            continue
        if math.gcd(value, num) == 1:
            num_list.append(num)
    if num_list:  # Если для числа не было найдено ни одного взаимно простого, то и выводить его не требуется.
        flag = False
        for number in num_list:
            if flag:
                text += ', '
            text += number.__str__()
            flag = True
        print(text)
