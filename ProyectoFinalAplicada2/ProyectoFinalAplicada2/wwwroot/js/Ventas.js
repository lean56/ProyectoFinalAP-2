class Ventas {

    pagos(evt, input) {
        if (evt != null) {
            if (filterFloat(evt, input)) {

            }
        } else {
            $("#vtDeuda").text("$0.0000000");
        }
    }
}