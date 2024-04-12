file = open("17.txt")
_list = [int(x) for x in file]
counter = 0
max_sum = 0
max17 = max([i for i in _list if i % 100 == 17])
for i in range(len(_list) - 2):
    if (
            (sum(1 for num in _list[i:i + 3] if 1000 <= num <= 9999) == 2)
            and
            (any(num % 5 == 0 for num in _list[i:i + 3]))
            and
            (sum(_list[i:i + 3]) > max17)
    ):
        counter += 1
        max_sum = max(max_sum, sum(_list[i:i + 3]))
print(counter, max_sum)
