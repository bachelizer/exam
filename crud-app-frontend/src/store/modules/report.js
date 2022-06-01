import Vue from 'vue';
import Vuex from 'vuex';

import report from '@/helper/services/report.services';

Vue.use(Vuex);

export default {
  namespaced: true,
  state: {
    reportNumber: [],
  },
  mutations: {
    
  },
  actions: {
    async fetchReportNumbers({ commit }) {
      try {
        const { data } = await report.fetchReportNumbers();

      } catch (error) {
        console.log(error);
        throw error;
      }
    },
  },
};
