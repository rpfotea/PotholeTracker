$(document).ready(function reportMap() {

    var cleveland = { lat: 41.505, lng: -81.681 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 13,
        center: cleveland
    });
    
    var pothole;

    google.maps.event.addListener(map, 'click', function (event) {

        if (pothole) {
            pothole.window.close();
            pothole.pin.setMap(null);
        }

        pothole = placeMarker(event.latLng);
        google.maps.event.addListener(pothole.window, 'closeclick', function (event) {
            pothole.pin.setMap(null);
        });
    });

    var contentString = '<a href="/function/savepothole">Submit Pothole</a>';


    //var image = 'https://cdn2.iconfinder.com/data/icons/bad-day/64/flat_tire_unhappy_bad_luck_depression_fail_failure_defeat-512.png';

    function placeMarker(location) {

        var marker;

        if (marker) {
            marker.setPosition(location);
        } else {
            marker = new google.maps.Marker({
                position: location,
                map: map,
                //icon: image
            });
        }

        var infowindow = new google.maps.InfoWindow({
            content: contentString
        });

        infowindow.open(map, marker);

        return {
            pin: marker,
            window: infowindow
        }
    }

    //function openWindow() {
    //    infowindow = new google.maps.InfoWindow({
    //        content: contentString
    //    });
    //    infowindow.open(map, marker);
    //}
});