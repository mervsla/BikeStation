$(document).ready(function () {

    var list = @Html.Raw(Json.Serialize(Model));
    stationNames = JSLINQ(list)
        .Select(function (x) { return x.stationName }).ToArray();

    var series = JSLINQ(list)
        .Select(function (x) { return x.series }).ToArray();


    var chart = Highcharts.chart('container', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Bike Availability at Stations'
        },
        xAxis: {
            categories: stationNames
        },
        yAxis: {
            title: {
                text: 'Number of Bikes Available'
            },
        },
        tooltip: {
            pointFormat: '{series.name}: {point.y}'
        },
        series: series
    });


});