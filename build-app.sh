#Build Angular app
cd ./TourManagerUI/
npm install
npm install -g @angular/cli > /dev/null
ng build --configuration="production"
cd ..

cp ./TourManagerUI/dist/TourManagerUI/* ./TourManagerBackEnd/TourManagerBackEnd/wwwroot/ 


