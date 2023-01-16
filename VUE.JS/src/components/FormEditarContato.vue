<template>
    <div class="form-group">
        <h2>Editar contato</h2>
        <form class="was-validated" @submit.prevent="postData">
            <label for="IdContato"> ID</label>  <br>
                <input type="number" min="1" name="IdContato" id="IdContato" v-model="form.id" class="form-control" placeholder="Ex.: 1" required>
            <br>
            <label for="NomeContato"> Nome</label>  <br>
                <input type="text" name="NomeContato" id="NomeContato" v-model="form.nome" class="form-control" placeholder="Ex.: Nome" pattern="[a-zA-Z\s]+" required>
            <br>
            <label for="EmailContato"> Email</label>  <br>
                <input type="email" name="EmailContato" id="EmailContato" v-model="form.email"  class="form-control" placeholder="Ex.: email@mail.com" required>
            <br>
            <label for="TelefoneContato"> Telefone</label>  <br>
                <input type="tel" name="TelefoneContato" id="TelefoneContato" v-model="form.numero"  class="form-control" placeholder= "Ex.: (81) 999999999" pattern="^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$" required>
            <br>
            <input type="submit" value="Editar contato" class="btn btn-primary" @click="putData(form.id)"/>
        </form>
    </div>
</template>

<script>

import axios from 'axios'

export default{
    name: 'FormEditarContato',
    data() {
        return {
            contato: [],
            form: {
                id: '',
                nome: '',
                email: '',
                numero: '',
            }
        }
    },
    methods: {
        putData(id) {
            axios.put(`https://localhost:7296/Contato/update/${id}`, this.form)
            .then(() => {
                alert("Dados atualizados!")
            })
            .catch((error) => {
                alert(error)
            });
        }

    }
}
</script>