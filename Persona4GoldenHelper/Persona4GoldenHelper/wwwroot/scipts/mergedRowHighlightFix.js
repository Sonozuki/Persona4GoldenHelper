$('tbody tr').hover(addHoverClass, removeHoverClass);

function addHoverClass() {
    // get the cell that is merged over the rows
    var mergedTableCell = $(this).parent().children()[0].cells[0];
    console.log(mergedTableCell);

    // add the hover class to make it appear as if it's being hovered
    if (!$(mergedTableCell).hasClass('hover-table-cell')) {
        $(mergedTableCell).addClass('hover-table-cell');
    }
}

function removeHoverClass() {
    // get the cell that is merged over the rows
    let mergedTableCell = $(this).parent().children()[0].cells[0];

    // remove the hover class so it doesn't appear as if it's being hovered
    $(mergedTableCell).removeClass('hover-table-cell');
}