int a;
int b;
int c;


int main() {
	c = 10;
	printi(c);
}

void main() {
	string a = "hello world";
	char b = 'b';
	prints(a);
	printc(b);
	read();
}

void main() {
	string a[10];
	a[1] = "hello world form arr";
	prints(a[1]);
	read();
}

void main() {
	bool t = 10 == 5;
	printb(t);
	t = 10 > 5;
	printb(t);
	t = 10 < 5;
	printb(t);
	t = 10 >= 5;
	printb(t);
	t = 10 <= 5;
	printb(t);
	read();
}

int qwe;
void printArr(int[] a, int arrLength) {
	for (int i = 0; i < arrLength; i++) {
		print(a[i]);
	}
}

void sort(int[] mas, int size){
	int temp;
	for (int i = 0; i < size; i++)
	{
		for (int j = i + 1; j < size; j++)
		{
			if (mas[i] > mas[j])
			{
				temp = mas[i];
				mas[i] = mas[j];
				mas[j] = temp;
			}
		}
	}
}

void main() {
	int h = qwe;
	int length = 5;
	int a[length];
	for (int i = 0; i <length; i++) {
		a[i] = length-i;
	}
	print("Input:");
	printArr(a, length);
	print();
	sort(a, length);
	print("Output:");
	printArr(a, length);
	read();
}

void main() {
	string t = fileRead("test.txt");
	prints(t);
	read();
}

void main() {
	int a[5];
	int b[5];
	a[1] = 5;
	b = a;
	printi(b[1]);
}

int i;
void main() {
	while (i < 10) {
		print(i);
		i++;
	}
	i = 0;
	do {
		print(i);
		i++;
	} while (i < 10);
	read();
}


void main() {
	string t = "asd";
	string tt = "asd";
	string ttt = "dsa";

	if (tt == t) {
		print(t);
	}
	
	if (ttt == tt) {
		print(tt);
	}
	else {
		print(ttt);
	}
	read();
}

void test(int a, int b) {
	print(a);
	print(b);
}

void main() {
	test(10 + 10 - 2 * 4, 99 - 24 + 1);
	read();
}

