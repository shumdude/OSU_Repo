# count = int(input("Введите количество детей: "))
# dictionary = dict()
counter = dict()
for i in range(3):
    value = input()
    values = value.split(":")
    # name = values[0]
    toys = set([x.strip() for x in values[-1].split(",")])
    # dictionary[name] = list(toys)
    for toy in toys:
        if counter.get(toy) is None:
            counter[toy] = 1
        else:
            counter[toy] += 1
for key, value in sorted(counter.items()):
    if value == 1:
        print(key)
# print(counter)
