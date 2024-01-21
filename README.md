docker build -t local-email-sender .

docker run --name local-email-sender -p 5000:80 local-email-sender:latest

docker-compose up
