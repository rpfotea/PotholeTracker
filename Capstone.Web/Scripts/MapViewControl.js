var potholeList = [];
var map;

function placePotholes(currentPotholes) {

    var cleveland = { lat: 41.505, lng: -81.681 };
    map = new google.maps.Map(document.getElementById('map'), {
        zoom: 15,
        center: cleveland
    });

    for (var i = 0; i < currentPotholes.length; i++) {

        var pothole = {
            pin: new google.maps.Marker({
                position: { lat: currentPotholes[i].Latitude, lng: currentPotholes[i].Longitude },
                map: map,
                icon: '/images/Logomakr_7fMxbC.png'
            })
        }
        potholeList.push(pothole);
    }

}

//function placePothole(Latitude, Longitude) {
//    var pothole = {
//        pin: new google.maps.Marker({
//        position: { lat: Latitude, lng: Longitude },
//        map: map
//        })
//    }
//    potholeList.push(pothole);
//}