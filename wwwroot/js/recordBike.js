function SubmitBike() {
    name = $('#bikeNameInput').val();
    bike_id = $('#bikeIdInput').val();
    station_id = $('#stationIdSelect').val();
    lon = $('#bikeLongitudeInput').val();
    lat = $('#bikeLatitudeInput').val();
    is_reserved = false;
    is_disabled = false;
    if (name != "" && station_id != "") {
        
        $.ajax({
            type: "POST",
            url: "/Home/AddBike",
            data: {
                'name': name,
                'bike_id': bike_id,
                'station_id': station_id,
                'lon': lon,
                'lat': lat,
                'is_reserved': is_reserved,
                'is_disabled': is_disabled,
            },
            success: function (response) {
                alert("Bisiklet kaydı başarıyla gerçekleşti.");
                $('#bikeSubmitForm').each(function () {
                    this.reset();
                });
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    }


}
