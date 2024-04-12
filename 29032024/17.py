file = open("17.txt")
_list = [int(x) for x in file]
counter = 0
min_sum = 1_000_000
max111 = max([i for i in _list if i % 111 == 0])
print(max111)
for i in range(len(_list) - 1):
    if (
            (_list[i] > max111 or _list[i + 1] > max111)
            and
            (_list[i] % 10 == 7 or _list[i + 1] % 10 == 7)
    ):
        counter += 1
        min_sum = min(min_sum, _list[i] + _list[i + 1])
print(counter, min_sum)
