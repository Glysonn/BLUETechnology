<!-- a tabela deve ser preenchida com os dados retornados do endpoind. Dados atuais somente para demonstração-->
<template>
    <div>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Nome</th>
                    <th scope="col">Email</th>
                    <th scope="col">Telefone</th>
                    
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">1</th>
                    <td>Glyson</td>
                    <td>kauaglyson@gmail.com</td>
                    <td>(81) 983723417</td>
                    <td>
                        <a>Detalhes</a> &nbsp;
                        <a>Editar</a> &nbsp;
                        <a>Apagar</a> &nbsp;
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
    name: 'TabelaContatos'
}
</script>