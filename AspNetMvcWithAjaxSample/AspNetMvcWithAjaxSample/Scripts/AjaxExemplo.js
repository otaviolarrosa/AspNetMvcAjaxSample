AjaxExemplo = function () {
    $(document).ready(function () {
        $("#Link1").on("click", function () {
            var user = { // Isso é um objeto em JavaScript
                Id: 1,
                Nome: "Otávio",
                Sobrenome: "Larrosa"
            }

            $.ajax({ // Um Ajax com requisição do tipo POST
                type: "POST",
                url: "/Home/Index",
                data: user,
                success: function (data) {
                }
            });
        });
    });
}