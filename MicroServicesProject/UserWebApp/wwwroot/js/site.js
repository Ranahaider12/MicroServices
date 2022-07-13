$(document).ready(function () {
    $.ajax({
        url: "https://localhost:44320/gateway/user",
        type: "GET",
        headers: { 'Content-Type': 'application/json' },
        success: function (result) {
            console.log(result);
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.city + '</td>';
                html += '<td>' + item.email + '</td>';
                html += '<td>' + item.status + '</td>';
               
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    //$.ajax({
    //    type: 'GET',
    //    url: "https://localhost:44320/gateway/user",
    //    success: function (result) {
    //        alert('Successfully received Data ');
    //        console.log(result);
    //    },
    //    error: function () {
    //        alert('Failed to receive the Data');
    //        console.log('Failed ');
    //    }
    //})
});