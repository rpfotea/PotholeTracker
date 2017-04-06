$(document).ready(function initMap(){

        var cleveland = { lat: 41.505, lng: -81.681 };
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 15,
            center: cleveland
        });
        //var marker = new google.maps.Marker({
        //    position: cleveland,
        //    map: map
        //});

});