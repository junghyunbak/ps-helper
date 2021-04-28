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
	// stopwatch flag 
	bool stopwatch = false;
	// translate flag
	bool translate = false;
	bool reverse = false;
	// command-line arguments parsing
	int c;
	extern char* optarg;
	while((c = getopt(argc, argv, "rt:s")) != -1){
		switch(c){
			case 'r':
				reverse = true;
				break;
			case 't':
				translate = true;
				filePath = startupPath + "\\translate.exe";
				break;
			case 's':
				stopwatch = true;
				filePath = startupPath + "\\stopwatch.exe";
				break;
		}
	}
	if(translate){
		string tmp; 
		if(!reverse) tmp = filePath + " " + optarg + " i";
		else tmp = filePath + " " + optarg + " r";
		system(tmp.c_str());
		return 0;
	}
	if(stopwatch){
		execl(filePath.c_str(), "stopwatch", 0);
		return 0;
	}
	return 0;
}
