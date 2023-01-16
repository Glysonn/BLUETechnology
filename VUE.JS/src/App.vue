<template>
  <div>
    <nav class="navbar navbar-expand-sm bg-light navbar-light">
      <ul class="navbar-nav">
        <li class="nav-item">
        <router-link to="/" class="nav-link">Contatos</router-link>
        </li>
        <li class="nav-item">
        <router-link to="/adicionar" class="nav-link">Adicionar</router-link>
        </li>
      </ul>
    </nav>
    <hr>
    <router-view/>
  </div>
</template>

<style>
</style>
