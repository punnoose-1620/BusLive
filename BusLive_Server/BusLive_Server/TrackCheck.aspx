<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrackCheck.aspx.cs" Inherits="BusLive_Server.TrackCheck" %>

<!DOCTYPE html>
<html>
  <head>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">
    <title>Reverse Geocoding</title>
    <style>
      #map {
        height: 100%;
      }
      /* Optional: Makes the sample page fill the window. */
      html, body {
        height: 100%;
        margin: 0;
        padding: 0;
      }
      #floating-panel {
        position: absolute;
        top: 10px;
        left: 25%;
        z-index: 5;
        background-color: #fff;
        padding: 5px;
        border: 1px solid #999;
        text-align: center;
        font-family: 'Roboto','sans-serif';
        line-height: 30px;
        padding-left: 10px;
      }
      #floating-panel {
        position: absolute;
        top: 5px;
        left: 50%;
        margin-left: -180px;
        width: 350px;
        z-index: 5;
        background-color: #fff;
        padding: 5px;
        border: 1px solid #999;
      }
      #latlng {
        width: 225px;
      }
    </style>
          <script type="text/javascript" >

              var secs;
              var timerID = null;
              var timerRunning = false;
              var delay = 1000;

              function InitializeTimer(seconds) {
                  // Set the length of the timer, in seconds
                  secs = seconds;
                  StopTheClock();
                  StartTheTimer();
              }

              function StopTheClock() {
                  if (timerRunning)
                      clearTimeout(timerID);
                  timerRunning = false;
              }

              function StartTheTimer() {
                  if (secs == 0) {
                      StopTheClock();
                      // Here's where you put something useful that's
                      // supposed to happen after the allotted time.
                      // For example, you could display a message:
                      window.location.href = window.location.href;
                  }
                  else {
                      //self.status = 'Remaining: ' + secs;
                     // document.getElementById("lbltime").innerText = secs + " ";
                      secs = secs - 1;
                      timerRunning = true;
                      timerID = self.setTimeout("StartTheTimer()", delay);
                  }
              }
    </script>
  </head>
<body onload="InitializeTimer(10)">
    <div id="map"></div>
    <script>
        var lat = <%=_lat%>;
        var lon = <%=_lon%>;
        var maxZoomService;
 
      function initMap() {
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 20,
            center: { lat: lat, lng: lon }
        });
        var geocoder = new google.maps.Geocoder;
        var infowindow = new google.maps.InfoWindow;
        maxZoomService = new google.maps.MaxZoomService();


          geocodeLatLng(geocoder, map, infowindow);
      }

      function geocodeLatLng(geocoder, map, infowindow) {
        //var input = document.getElementById('latlng').value;
        //var latlngStr = input.split(',', 2);
        //var latlng = {lat: parseFloat(latlngStr[0]), lng: parseFloat(latlngStr[1])};
        var latlng = { lat: lat, lng: lon };
        geocoder.geocode({'location': latlng}, function(results, status) {
          if (status === 'OK') {
            if (results[1]) {
              map.setZoom(11);
              var marker = new google.maps.Marker({
                position: latlng,
                map: map
              });
              infowindow.setContent(results[1].formatted_address);
              infowindow.open(map, marker);
            } else {
              window.alert('No results found');
            }
          } else {
            window.alert('Geocoder failed due to: ' + status);
          }
        });
      }
    </script>
    <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD8wl6epJcppV1PMOYiQEzJ5R_ZkBuU6ME&callback=initMap">
    </script>
  </body>
</html>
