cd ./TourManagerBackEnd/

dotnet restore
dotnet publish -c Release -o publish

cd ../

mkdir -p AppDir/usr/bin


cp ./TourManagerBackEnd/publish/* AppDir/usr/bin/


USAGE=$(cat <<-END
   #!/bin/sh
    HERE="$(dirname "$(readlink -f "${0}")")"
    export PATH="${HERE}"/usr/bin/:"${PATH}"
    EXEC=$(grep -e '^Exec=.*' "${HERE}"/*.desktop | head -n 1 | cut -d "=" -f 2 | cut -d " " -f 1)
    exec "${EXEC}" $@
END
)

echo $USAGE

echo $USAGE >AppDir/AppRun



USAGE2=$(cat <<-END
# Desktop Entry Specification: https://standards.freedesktop.org/desktop-entry-spec/desktop-entry-spec-latest.html
[Desktop Entry]
Type=Application
Name=hwapp
Comment=Self-contained .NET Core console application that prints Hello World
Icon=hwapp
Exec=hwapp
Path=~
Terminal=true
Categories=Development;
END
)

echo $USAGE2 >AppDir/hwapp.desktop

wget "https://github.com/AppImage/AppImageKit/releases/download/continuous/appimagetool-x86_64.AppImage" -nc
chmod a+x appimagetool-x86_64.AppImage

./appimagetool-x86_64.AppImage ./AppDir

ls
./hwapp-x86_64.AppImage