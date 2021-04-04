#include <iostream>
#include <unistd.h>
#include <Windows.h>
#include <vector>
#define MAX_SIZE 1024
using namespace std;

int main(int argc, char** argv){
	// get file path
	char buf[MAX_SIZE] = { 0 };
	GetModuleFileName(NULL, buf, MAX_SIZE);
	string startupPath(buf);
	int idx = startupPath.rfind("\\");
	startupPath.erase(startupPath.begin()+idx, startupPath.end());
	string filePath;
	// flag
	bool stopwatch = false;
	// command-line arguments parsing
	int c;
	extern char* optarg;
	while((c = getopt(argc, argv, "tr:s")) != -1){
		switch(c){
			case 't':
				break;
			case 'r':
				break;
			case 's':
				stopwatch = true;
				filePath = startupPath + "\\stopwatch.exe";
				break;
		}
	}
	if(stopwatch){
		execl(filePath.c_str(), "stopwatch", 0);
	}
	return 0;
}
