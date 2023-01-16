<template>
    <div class="form-group">
        <h2>Adicionar novo contato</h2>
        <form class="was-validated">
            <label for="NomeContato"> Nome</label>  <br>
                <input type="text" name="NomeContato" id="NomeContato" class="form-control" required>
            <br>
            <label for="EmailContato"> Email</label>  <br>
                <input type="text" name="EmailContato" id="EmailContato" class="form-control" required>
            <br>
            <label for="TelefoneContato"> Telefone</label>  <br>
                <input type="tel" name="TelefoneContato" id="TelefoneContato" class="form-control" required>
            <br>
            <input type="submit" value="Adicionar contato" class="btn btn-primary"/>
        </form>
    </div>
</template>

<script>

export default{
    name: 'FormAddContato',
}
</script>