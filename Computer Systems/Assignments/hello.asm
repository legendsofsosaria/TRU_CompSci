hello:
    .string "Hello world!\n"
hello_end: 
   .equ len, hello - hello_end
.text
.globl _start 
_start:
        movq $1, %rax
        movq $1, %rdi 
        movq $string, %rsi
        movq $len, %rdx
        syscall
        movq $60, %rax
        movq $0, %rdi
        syscall