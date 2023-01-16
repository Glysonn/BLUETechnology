<template>
    <tbody>
        <tr v-for="pessoa in contatos" :key="pessoa.id">
            <th scope="row">{{ pessoa.id }}</th>
            <td>{{ pessoa.nome }}</td>
            <td>{{ pessoa.email }}</td>
            <td>{{ pessoa.numero }}</td>
            <td>
                <a>Detalhes</a> &nbsp;
                <a>Editar</a> &nbsp;
                <a>Apagar</a> &nbsp;
            </td>
        </tr>
    </tbody>
</template>

<script>
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
            const apiUrl = 'https://localhost:7296/contato';
            fetch(apiUrl)
            .then(response => response.json())
            .then(data => {
                this.contatos = data.sort()
            })
            .catch('Erro ao carregar dados:');
            }
    }
}
</script>