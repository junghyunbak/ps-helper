# PS Helper

## 개요

콘솔 환경에서 명령어 형태로 사용 가능한 윈폼 애플리케이션

알고리즘 문제풀이(Problem Solving) 연습에 필요한 도구 제공

## 사용방법

./psHelper/bin 폴더 환경변수 등록 후 **psh \-\[option\] \[value\]** 형태로 사용

## 기능

1. 스톱워치

실행 중 focus 된 프로세스 핸들을 얻어와 단계별로 걸린 시간을 측정

```c++
> psh -s // start stopwatch
```

![noname05](https://user-images.githubusercontent.com/44913775/120892537-cda53280-c649-11eb-993e-ff0fe2ba4d44.png)

![noname02](https://user-images.githubusercontent.com/44913775/116445232-998f6280-a890-11eb-89d4-91c02c94bad7.png)

2. 번역기

```c++
> psh -t "apple" // 사과
> psh -rt "apple" // "apple"
> psh -r -t "사과" // "apple"
```

![noname03](https://user-images.githubusercontent.com/44913775/116451631-b3807380-a897-11eb-8aeb-14562f18d2f2.png)

3. 계산기

스톱워치의 부가 기능

* 밑이 2 인 log 계산기

![noname03](https://user-images.githubusercontent.com/44913775/120892422-29bb8700-c649-11eb-904e-b94b0ead2070.png)
![noname04](https://user-images.githubusercontent.com/44913775/120892423-2a541d80-c649-11eb-8487-f6df90970827.png)

* 조합 계산기 C(n, r)

![noname01](https://user-images.githubusercontent.com/44913775/120892420-288a5a00-c649-11eb-977c-37bae8023d38.png)
![noname02](https://user-images.githubusercontent.com/44913775/120892421-29bb8700-c649-11eb-80fe-0c6f08e287c3.png)

4. 도움말

```c++
> psh -h // start helper
```

![그림2](https://user-images.githubusercontent.com/44913775/120919961-41514900-c6f7-11eb-9a60-45ffd956ee5e.png)

5. 설정

```c++
> psh -m // start modify
```

![그림1](https://user-images.githubusercontent.com/44913775/120892495-946cc280-c649-11eb-8de0-59470c23ce67.png)

## 사용된 API, 라이브러리

+ papago api
+ markdig
