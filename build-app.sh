#Build Angular app
mkdir ./TourManagerBackEnd/TourManagerWeb/wwwroot/ 

cd ./TourManagerUI/
npm install
npm install -g @angular/cli > /dev/null
ng build --configuration="production"
cd ..
DIR=./TourManagerBackEnd/TourManagerWeb/wwwroot/ 

if [[ ! -e $DIR ]]; then
    mkdir $DIR
elif [[ ! -d $DIR ]]; then
    echo "$DIR already exists but is not a directory" 1>&2
fi
cp ./TourManagerUI/dist/TourManagerUI/* ./TourManagerBackEnd/TourManagerWeb/wwwroot/ 
cd ./TourManagerBackEnd/TourManagerWeb/
dotnet tool install ElectronNET.CLI -g
electronize build /target linux

git log --tags --simplify-by-decoration --pretty="format:%ci %d"





