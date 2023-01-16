<template>
    <div class="form-group">
        <h2>Adicionar novo contato</h2>
        <form class="was-validated" @submit.prevent="postData">
            <label for="NomeContato"> Nome</label>  <br>
                <input type="text" name="NomeContato" id="NomeContato" v-model="form.nome" class="form-control" placeholder="Ex.: Nome" pattern="[a-zA-Z\s]+" required>
            <br>
            <label for="EmailContato"> Email</label>  <br>
                <input type="email" name="EmailContato" id="EmailContato" v-model="form.email"  class="form-control" placeholder="Ex.: email@mail.com" required>
            <br>
            <label for="TelefoneContato"> Telefone</label>  <br>
                <input type="tel" name="TelefoneContato" id="TelefoneContato" v-model="form.numero"  class="form-control" placeholder= "Ex.: (81) 999999999" pattern="^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$" required>
            <br>
            <input type="submit" value="Adicionar contato" class="btn btn-primary"/>
        </form>
    </div>
</template>

<script>
import axios from 'axios'

export default{
    name: 'FormAddContato',
    data() {
        return {
            form: {
                nome: '',
                email: '',
                numero: '',
            }
        }
    },
    methods: {
        async postData() {
            const apiUrl = "https://localhost:7296/Contato";
            try {
                await axios.post(apiUrl, this.form)
                alert("Contato salvo!");
            } catch (error) {
                console.error(error)
            }
        }

    }
}
</script>