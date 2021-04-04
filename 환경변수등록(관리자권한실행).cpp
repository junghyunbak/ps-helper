#include <iostream>
#include <unistd.h>
#include <string>
#define MAX_SIZE 1024
using namespace std;


int main(){
	char buf[MAX_SIZE];
	getcwd(buf, MAX_SIZE);
	string path(buf);
	string fullPath = "setx path \"\%path\%" + path + "\\bin;\" -m";
	system(fullPath.c_str());
	return 0;
}
