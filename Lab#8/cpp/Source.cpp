#include <iostream>
#include <iomanip>
#include <vector>
using namespace std;

struct List{
	long int elem;
	int count;
	List* next;
	List* prev;
};

List* root(long int a){
	List* lst = new List();					// ��������� ������ ��� ������ ������
	lst->elem = a;
	lst->next = NULL;					// ��������� �� ��������� ����
	lst->prev = NULL;					// ��������� �� ���������� ����
	return(lst);
}
List* push_Back(List *list, long int value) {
	List* tmp = root(value);
	tmp->elem = value;
	tmp->next = NULL;
	tmp->prev = list;
	tmp->count = list->count+1;


	if (list) {
		list->next = tmp;
	}
	list = tmp;
	
	return list;
}


int CountMultiples(List* head)
{
	List* ref = head;
	int k = 0;
	while (ref)
	{
		if (ref->elem % 5 == 0 && ref->count%2==0)
		{
			k++;
		}
		ref = ref->next;
	}
	return k;
}
void Delete(List* Head, int nom)     // �������� �������� � �������� �������.
{
	//������� ����
	List* current = Head;
	List* current1;
	//���� �������
	while (current)
	{
		if (current->elem >= nom){
			//������ �����
			if (current->prev != nullptr)current->prev->next = current->next;
			if (current->next != nullptr)current->next->prev = current->prev;
			//���� ���� �������� ������w
			if (Head == current) Head = current->next;
			//�������
			current1 = current->next;
			cout << "Element number " << current->count+1 << " has been deleted" << endl;
			delete current;
			current = current1;
		}
		else{
			current = current->next;
		}
	}
}
int main(){
	setlocale(LC_ALL, "ru");
	cout << "Kovalenko Yevhen IS-93 Variant#10" << endl;
	vector<long int> arr;

	List* head= NULL;
	List* elem = NULL;
	long int a;
	double averange;
	long int sum = 0;
	int av;

	cout << "����i�� ������ ������� ������" << endl;
	cin >> a;
	arr.push_back(a);
	head = root(a);
	elem = head;

	bool alive = true;

	while (alive){
		cout << endl;
		cout << "1.������ ������� � �i���� ������" <<"  " <<"2.�i���i��� ������� 5 �� ������ �����i��" << endl;
		cout << "3.�������� �������� ��i �i���� ����������" << " " << "4.����� � ��������" << endl;
		cout << endl;
		int command;
		cin >> command;
		switch(command){
			case 1:
				cout << "������ �������: " << endl;
				cin >> a;
				arr.push_back(a);
				elem = push_Back(elem, a);
				break;
			case 2:
				cout <<"�i����i��: " <<CountMultiples(head) << endl;
				break;
			case 3:
				for (int i : arr){
					sum = sum + i;
				}
				averange = sum / arr.size();
				av = int(averange);
				cout <<"������� ��������: "<< av << endl;
				Delete(head, av);
				break;
			case 4:
				alive = false;
				continue;
		}
	}

	system("pause");
	return 0;
}

