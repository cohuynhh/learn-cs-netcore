# Create Project
```
dotnet new web
open . # Open by VSC
```
# Create package.json
```
npm init
```
# Install Bootstrap, JQuery
```
npm install bootstrap
npm install jquery
npm i popper.js
```
# Setup  BuildBundlerMinifier
```
dotnet add package BuildBundlerMinifier # add package
```
Create ```bundleconfig.json``` file with content as 
[bundleconfig.json](https://raw.githubusercontent.com/xuanthulabnet/learn-cs-netcore/master/CS24-Asp.net-core/HelloWorld/bundleconfig.json)

# Run
```
dotnet watch run # auto build
```
Open link  [localhost:5000](http://localhost:5000/)

npm i -D webpack webpack-cli node-sass postcss-loader postcss-preset-env sass-loader css-loader cssnano mini-css-extract-plugin cross-env file-loader

