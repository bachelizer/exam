import Vue from 'vue';
import Vuex from 'vuex';

import instructor from './modules/instructor';
import report from './modules/report';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {},
  mutations: {},
  actions: {},
  modules: {
    instructor,
    report,
  },
});
