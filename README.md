# psHelper

## 개요

콘솔 환경에서 명령어 형태로 사용 가능한 윈폼 애플리케이션

알고리즘 문제풀이(Problem Solving) 연습에 필요한 도구 제공

## 사용방법

./bin 폴더 환경변수 등록 후 **psh \-\[option\] \[value\]** 형태로 사용

## 기능

1. 스톱워치
    + 실행 중 focus 된 프로세스 핸들을 얻어와 단계별로 걸린 시간을 측정
```c++
> psh -s // start stopwatch
```
![noname01](https://user-images.githubusercontent.com/44913775/116445231-985e3580-a890-11eb-91ad-81ebdb71334f.png)

![noname02](https://user-images.githubusercontent.com/44913775/116445232-998f6280-a890-11eb-89d4-91c02c94bad7.png)

2. 번역기
    + papago api 이용
```c++
> psh -t "apple" // 사과
> psh -rt "apple" // "apple"
> psh -r t "사과" // "apple"
```
![noname03](https://user-images.githubusercontent.com/44913775/116451045-fee65200-a896-11eb-9f8b-903f74d48290.png)

3. 계산기 🚧
4. 도움말 🚧
5. 설정 🚧
