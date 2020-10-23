#Build Angular app
cd ./TourManagerUI/
ng build --configuration="production"
cd ..

cp ./TourManagerUI/dist/TourManagerUI/* ./TourManagerBackEnd/TourManagerBackEnd/wwwroot/ 
