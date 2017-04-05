$(document).ready(function initMap() {

    var cleveland = { lat: 41.505, lng: -81.681 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 13,
        center: cleveland
    });

    var marker;
    //var image = 'https://cdn2.iconfinder.com/data/icons/bad-day/64/flat_tire_unhappy_bad_luck_depression_fail_failure_defeat-512.png';

    function placeMarker(location) {
        if (marker) {
            marker.setPosition(location);
        } else {
            marker = new google.maps.Marker({
                position: location,
                map: map,
                //icon: image
            });
        }
    }

    var contentString = '<a href="/function/savepothole">Submit Pothole</a>'

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    google.maps.event.addListener(map, 'click', function (event) {
        placeMarker(event.latLng);
        infowindow.open(map, marker);
    });

    google.maps.event.addListener(infowindow, 'closeclick', function (event) {
        marker.setMap(null);
    });

});