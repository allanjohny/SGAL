function verificaValor(valor) {
    return valor != "" && valor != null && valor != undefined && valor != "undefined";
}

function CarregarMunicipio(uf) {
    jQuery.post(content + "Base/ObterMunicipios", { uf: uf })
    .success(function (data) {
        jQuery("#municipioid").empty();
        jQuery("#municipioid").select2('val', null);
        if (data.ParametrosAdicionais.length > 0) {
            jQuery("#municipioid").append("<option value=\"\" selected>Selecione...</option>");
        }
        jQuery(data.ParametrosAdicionais).each(function () {
            jQuery("#municipioid").append("<option value=\"" + this.Key + "\">" + this.Value + "</option>");
        });
        jQuery("#municipioid").select2('val', "");
    })
    .error(function (err) {
    });
}

function soNumero(campo) {

    v = campo.value;

    RegExp = /^[0-9]+$/;

    if (!RegExp.test(v)) {

        // não contem so numeros
        return false;
    }

    return true;

}

function validaEmail(email) {
    var re = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
    return re.test(email);
}

var SPMaskBehavior = function (val) {
    return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00009';
},
    spOptions = {
        placeholder: "(__) ____-____",
        onKeyPress: function (val, e, field, options) {
            field.mask(SPMaskBehavior.apply({}, arguments), options);
        }
    };


function mensagem(texto, botoes) {
    if (!verificaValor(botoes)) {
        botoes = [];
    }

    if (botoes.length > 0) {
        $("#divMensagem").noty({
            text: texto,
            buttons: botoes
        });
    } else {
        $("#divMensagem").noty({
            text: texto
        });
    }
}


function mensagemSucesso(texto, botoes) {
    if (!verificaValor(botoes)) {
        botoes = [];
    }

    if (botoes.length > 0) {
        $("#divMensagem").noty({
            text: texto,
            type: "success",
            buttons: botoes
        });
    } else {
        $("#divMensagem").noty({
            text: texto,
            type: "success"
        });
    }
}

function mensagemErro(texto, botoes) {
    if (!verificaValor(botoes)) {
        botoes = [];
    }

    if (botoes.length > 0) {
        $("#divMensagem").noty({
            text: texto,
            type: "error",
            buttons: botoes
        });
    } else {
        $("#divMensagem").noty({
            text: texto,
            type: "error"
        });
    }
}

function mensagemAviso(texto, botoes) {
    if (!verificaValor(botoes)) {
        botoes = [];
    }

    if (botoes.length > 0) {
        $("#divMensagem").noty({
            text: texto,
            type: "warning",
            buttons: botoes
        });
    } else {
        $("#divMensagem").noty({
            text: texto,
            type: "warning"
        });
    }
}

function mensagemInformativa(texto, botoes) {
    if (!verificaValor(botoes)) {
        botoes = [];
    }

    if (botoes.length > 0) {
        $("#divMensagem").noty({
            text: texto,
            type: "information",
            buttons: botoes
        });
    } else {
        $("#divMensagem").noty({
            text: texto,
            type: "information"
        });
    }
}
