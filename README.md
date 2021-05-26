# BusLive
Cross Platform App for Bus Tracking using Client Side and Driver Side Application with database and website in the hosted Server. This project was completely developed on Visual Studio Community 2017, including both cross platform applications and html webpages.

This project consists of 3 parts :
- Client Side Application
- Driver Side Application
- Website
- Hosted Database

Client Side :
  This is a cross-platform application that is programmed using C# and Xamarin for Android and iOS. This app is meant to be used by any client who wishes to view where each registered bus is. The function of this app is to fetch current latitude and longitude of the selected bus (from a list of buses) and plot it on Google Maps using Google Maps API. Additionally, this app also has the routes of each bus stored as names of consequent stops en route.
  
Driver Side :
  This is a cross-platform application that is programmed using C# and Xamasin for Android and iOS. This app is meant to be installed on the phone of the driver of each bus and the driver is supposed to set his bus number on the app before starting. The function of this app is to periodically retrieve the current latitude and longitude of the bus using Google Maps API and send it to the hosted server.
  
Website :
  This section includes a html page that performs the same functions as the client side application. This was intended for desktop use and does not include a mobile version of the site. This was earlier hosted on GoDaddy.com during the period of our project and was later taken down after completion of formalities.
  
Hosted Database :
  This is an SQL database that was hosted on GoDaddy.com to store the bus number, latitude, longitude, and last updated time with bus number as the primary key. This was meant to be a log of where each bus was at a given period of time. The values in this database are added only by the driver side app. These values can be viewed and retrieved only by the Client Side App and Website.

 
