
int[] test(int a, int[] a) {
	return 0;
}

void main() {
	int a = 1;
	if (a == 1) {
		printi(a);
	}
	read();
	return;
}

int[] sort(int[] a, int n) {
	int c = 0;
	for (int i = 0; i < n - 1; i++) {
		int b;
	}
}



int[] sort(int[] a, int n) {
	int c = 0;
	for (int i = 0; i < n - 1; i++) {
		for (int j = n - 2; j >= i; j--) {
			if (a[j] > a[j + 1]) {
				c = a[j]; 
			}
		}
	}
}

int a;
int b;
int c;


int main() {
	c = 10;
	printi(c);
}

void main() {
	a(10)
	read();
}

void main() {
	c = 125;
	c = c + 40 - 10;
	printi(c);
	read();
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

void rec(int i) {
	printi(i);
	if (i > 10) {
		return;
	}
	rec(i + 1);
}

void ptArr(int[] a, int arrLength) {
	for (int i = 0; i < arrLength; i++) {
		printi(a[i]);
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
	int length = 5;
	int a[length];
	for (int i = 0; i <length; i++) {
		a[i] = length-i;
	}
	prints("Input:");
	ptArr(a, length);
	prints("");
	sort(a, length);
	prints("Output:");
	ptArr(a, length);
	read();
}

int a;

int main() {
	bool a = true;
	bool b = false;
	bool c = true;
	bool t = (c || a&&b) && b;
	printb(t);
	read();
}


void testt() {
	int j;
	while (j == 0) {
		int a;
	}

	do {
		int a;
	} while (j == 0);

	for (int i = 0; i < 10; i++) {
		int a;
	}

	if (j == 0) {
		int a;
	}
}

void t() {
	return 5;
}

string testtt(string f) {
	a(a,b,c,d,f);
}

void test(int[] a) {
	a[0] = a[2];
}

void main() {
	int a[5];

	test(a);
}

