def prime_number(n):
    number = [True] * n
    number[0] = False
    number[1] = False
    for i in range(2, int(n ** 0.5) + 1):
        if number[i]:
            for j in range(i ** 2, n, i):
                # все его множители помечаются как непростые
                number[j] = False
    primes = [i for i in range(n) if number[i]]
    return primes


primes = prime_number(500000)

count = 0
num = 500000

while count < 7 and num > 1:
    S = sum([prime for prime in primes if prime != num and num % prime == 0])
    if S != 0 and S % 10 == 0:
        print(num, S)
        count += 1
    num -= 1
