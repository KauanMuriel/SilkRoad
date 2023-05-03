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
      path: '/driver/all',
      component: () => import('../views/Driver/List.vue')
    },
    {
      path: '/vehicle/register',
      component: () => import('../views/Vehicle/Register.vue')
    },
    {
      path: '/model/all',
      component: () => import('../views/Model/List.vue')
    }
  ]
});

export default router
