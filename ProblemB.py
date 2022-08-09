#!/bin/usr/python3
'''
author : AmirZoyber
'''

alphabets = input()
chars = list("abcdefghijklmnopqrstuvwxyz")
counter = 0
for i in range(26):
    if (chars[i] in alphabets):
        counter+=1
print(counter)