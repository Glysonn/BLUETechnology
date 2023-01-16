import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/adicionar',
    name: 'adicionar',
    component: () => import('../views/AdicionarView.vue')
   },
   {
    path: '/editar',
    name: 'editar',
    component: () => import('../views/EditarView.vue')
   }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
