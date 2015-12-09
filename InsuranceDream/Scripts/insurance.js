$(document).ready(function () {
    $fireOptionCheck = $("#fireOptionCheck");
    $basePriceVal = $("#basePriceVal");
    $salesPriceVal = $("#salesPriceVal");

    $fireOptionCheck.on("click", function () {
        var isChecked = $fireOptionCheck.is(':checked');
        if (isChecked) {
            displayPrice("Home/CheckFireOption");
        }
        else {
            displayPrice("Home/ReinitPrice");
        }
    });

    function displayPrice(calculatePriceUrl) {
        $.post(calculatePriceUrl, null, function (data) {
            //console.log(data);
            $basePriceVal.empty();
            $salesPriceVal.empty();
            $basePriceVal.append(data.BasePrice);
            $salesPriceVal.append(data.SalesPrice);
        });
    }
});