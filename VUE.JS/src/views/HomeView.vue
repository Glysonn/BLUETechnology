<template>
  <div>
    <BtnAddContato />
    <br>
    <TabelaContatos />
  </div>
</template>

<script>
import BtnAddContato from '@/components/BtnCRUD/BtnAddContato.vue';

import TabelaContatos from '@/components/TabelaContatos.vue'
export default{
  name: 'HomeView',
  components: {
    BtnAddContato,
    TabelaContatos
  }
}
</script>  