$(document).ready(function () {
    $fireOptionCheck = $("#fireOptionCheck");
    $basePriceVal = $("#basePriceVal");
    $salesPriceVal = $("#salesPriceVal");

    $fireOptionCheck.on("click", function () {
        var isChecked = $fireOptionCheck.is(':checked');
        if (isChecked) {
            displayPrice("/Home/CheckFireOption");
            $salesPriceVal.css('text-shadow', "2px 2px 4px #000000");
            $basePriceVal.css('text-shadow', "2px 2px 4px #000000");
        }
        else {
            displayPrice("/Home/ReinitPrice");
            $basePriceVal.css('text-shadow', "");
            $salesPriceVal.css('text-shadow', "");
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