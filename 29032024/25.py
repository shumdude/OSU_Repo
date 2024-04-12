def is_prime(number) -> bool:
    if number % 2 == 0:
        return number == 2
    d = 3
    while d * d <= number and number % d != 0:
        d += 2
    return d * d > number


_index = 1
for i in range(194441, 196500 + 1):
    if i % 100 == 93:
        if is_prime(i):
            print(_index, i)
    _index += 1
