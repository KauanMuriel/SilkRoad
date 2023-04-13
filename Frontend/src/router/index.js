import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    // {
    //   component: HomeView
    // },
    // {
    //   path: '/about',
    //   name: 'about',
    //   // route level code-splitting
    //   // this generates a separate chunk (About.[hash].js) for this route
    //   // which is lazy-loaded when the route is visited.
    //   component: () => import('../views/AboutView.vue')
    // }
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
    }
  ]
})

export default router
