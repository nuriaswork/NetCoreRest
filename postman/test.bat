call newman run PostmanTesting.postman_collection.json -x --reporters cli,junit Results\PostmanJunit.xml
call newman run test.postman_collection.json -x  -r htmlextra --reporters cli,junit --reporter-junit-export Results\junitReport2.xml 
call newman run Login/Login.postman_collection.json -e Login/Login.Azure.postman_environment.json -d Login/login.data.csv -x -r junitfull --reporter-junitfull-export Results/junitReport3.xml -n 2
call newman run Login/Login.postman_collection.json -e Login/Login.Azure.postman_environment.json -d Login/login.data.csv -x  -r htmlextra --reporter-htmlextra-export Results/report.html
call newman run Login/Login.postman_collection.json -e Login/Login.Azure.postman_environment.json -d Login/login.data.csv -x  --reporters cli,junit Results\LoginJunit.xml
