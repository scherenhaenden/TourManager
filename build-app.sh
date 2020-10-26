#Build Angular app
cd ./TourManagerUI/
npm install
npm install -g @angular/cli > /dev/null
ng build --configuration="production"
cd ..

cp ./TourManagerUI/dist/TourManagerUI/* ./TourManagerBackEnd/TourManagerWeb/wwwroot/ 
cd ./TourManagerBackEnd/TourManagerWeb/
dotnet tool install ElectronNET.CLI -g
electronize build /target linux

git log --tags --simplify-by-decoration --pretty="format:%ci %d"





