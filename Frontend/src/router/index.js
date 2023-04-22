import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: () => import("../views/HomeView.vue")
    },
    {
      path: '/driver/register',
      component: () => import('../views/Driver/Register.vue')
    },
    {
      path: '/vehicle/register',
      component: () => import('../views/Vehicle/Register.vue')
    },
    {
      path: '/brand/register',
      component: () => import('../views/Brand/Register.vue')
    }
  ]
})

export default router
