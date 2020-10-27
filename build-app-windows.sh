#Build Angular app

echo 'build starting' 
echo 'windows build' 

echo 'build angular app'
cd ./TourManagerUI/
#npm install
#npm install -g @angular/cli

#ng build --configuration="production"

cd ..

DIR="./TourManagerBackEnd/TourManagerWeb/wwwroot/"

if [ ! -d $DIR ]; then
  mkdir -p $DIR;
fi

cp ./TourManagerUI/dist/TourManagerUI/* ./TourManagerBackEnd/TourManagerWeb/wwwroot/ 
cd ./TourManagerBackEnd/TourManagerWeb/
dotnet tool install ElectronNET.CLI -g
electronize build /target win

#git log --tags --simplify-by-decoration --pretty="format:%ci %d"





