<template>
    <tbody>
        <tr v-for="(pessoa, index) in contatos" :key="pessoa.id">
            <th scope="row">{{ ++index }}</th>
            <td v-text="pessoa.id"></td>
            <td v-text="pessoa.nome"></td>
            <td v-text="pessoa.email"></td>
            <td v-text="pessoa.numero"></td>
        </tr>
    </tbody>
</template>

<script>
import axios from 'axios'

export default {
    name: 'TBodyContatos',
    data () {
        return {
            contatos: []
        }
    },
    created(){
        this.getData()
    },
    methods:{
        getData() {
            axios.get('https://localhost:7296/Contato')
            .then(response => response.data)
            .then(data => {
                this.contatos = data.sort()
            })
            .catch(error => {console.log(error);});
        },
        deleteData(id) {
            axios.delete(`https://localhost:7296/Contato/delete/${id}`)
            .then(response => response.data)
            .then(data=> {
                alert("Contato deletado!");
                this.getData();
            })
            .catch(error => {console.log(error);});
        }
    }
}
</script>