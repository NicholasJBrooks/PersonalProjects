
function ChooseFile()
{
    $("#popup").load('ChooseFile');
}


function InputTransaction() {
    $("#popup").load('InputSingleTransaction');
}


function SaveTransactions() {
    $.ajax({

        'url': '/Import/SaveToTransactionDB',
        'type': 'POST',
        'success': function () {
            window.location.href = "/Home/Index"; 
        },
        'error': function () {
            alert("Failed To Save Transaction");
        }
    });

    $.ajax({
        'url': '/Home/Index',
        type: 'GET'
    });
}