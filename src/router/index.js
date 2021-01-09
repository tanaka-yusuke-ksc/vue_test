import Vue from 'vue'
import VueRouter from 'vue-router'


import login from '@/views/Login.vue'
import dialog from '@/components/Dialog.vue'
import calendar from '@/components/Calendar.vue'
import caldialog from '@/components/CalDialog.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'login',
    component: login
  },
  {
    path: '/dialog',
    name: 'dialog',
    component: dialog
  },
  {
     path: '/calendar',
     name: 'calendar',
     component: calendar
    },
  {
     path: '/caldialog',
     name: 'caldialog',
     component: caldialog
   },
  {
    path: '/gettest',
      name: 'gettest',
    component: () => import('@/components/GetTest.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
