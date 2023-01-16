<template>
    <div>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">ID</th>
                    <th scope="col">Nome</th>
                    <th scope="col">Email</th>
                    <th scope="col">Telefone</th>
                    
                </tr>
            </thead>
            <TBodyContatos />
        </table>
    </div>
</template>

<script>
import TBodyContatos from './TBodyContatos.vue';
export default {
    name: 'TabelaContatos',
    components: {
        TBodyContatos
    }
}
</script>