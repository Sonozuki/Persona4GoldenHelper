$('tbody tr').hover(addHoverClass, removeHoverClass);

function addHoverClass() {
    // get the first table row in the tbody, this is what will contain all the merged cells
    var mergedTableCellParent = $(this).parent().children()[0];

    // check each cell for it's rowspan value
    for (let tableCell of mergedTableCellParent.children) {
        let rowspan = $(tableCell).attr('rowspan');

        // check if it's more than 1 (meaning its a merged cell that should be highlighted)
        if (rowspan > 1) {
            if (!$(tableCell).hasClass('hover-table-cell')) {
                $(tableCell).addClass('hover-table-cell');
            }
        }
    }
}

function removeHoverClass() {
    // get the first table row in the tbody, this is what will contain all the merged cells
    var mergedTableCellParent = $(this).parent().children()[0];

    // check each cell for it's rowspan value
    for (let tableCell of mergedTableCellParent.children) {
        let rowspan = $(tableCell).attr('rowspan');

        // check if it's more than 1 (meaning its a merged cell that would be highlighted)
        if (rowspan > 1) {
            $(tableCell).removeClass('hover-table-cell');
        }
    }
}