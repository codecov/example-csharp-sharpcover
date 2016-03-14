FROM mono:latest

ADD . /src

RUN apt-get update && apt-get install make

CMD cd ./src; make coverage; cat coverageResults.txt
