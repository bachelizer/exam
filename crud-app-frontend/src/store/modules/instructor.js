import Vue from 'vue';
import Vuex from 'vuex';

import instructor from '@/helper/services/crud.services';

Vue.use(Vuex);

export default {
  namespaced: true,
  state: {
    instructor: [],
  },
  mutations: {

  },
  actions: {
    async fetchInstructors({ commit }) {
      try {
        const { data } = await instructor.fetchInstructors();
        
      } catch (error) {
        console.log(error);
        throw error;
      }
    },

    async addInstructors({ commit }, data) {
      try {
        await instructor.addInstructors(data);
      } catch (error) {
        console.log(error);
        throw error;
      }
    },

    async updateInstructor({ commit }, data) {
      try {
        await instructor.updateInstructor(data);
      } catch (error) {
        console.log(error);
        throw error;
      }
    },

    async deleteInstructor({ commit }, id) {
      try {
        await instructor.deleteInstructor(id)
      } catch (error) {
        console.log(error)
        throw error;
      }
    }
  },
};
