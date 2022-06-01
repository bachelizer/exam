<template>
  <div class="d-flex flex-wrap justify-content-center mt-5">
    <div class="col-md-6">
      <div style="align-content: center">
        <instructor-form
          :info="info"
          @form-submit="
            operation === 'add' ? handleSubmit(info) : handleSave(info)
          "
          :operation="operation"
        ></instructor-form>
      </div>
      <div class="card mt-3">
        <div class="card-body">
          <div class="row">
            <div class="col">
              <input
                v-model="search"
                type="text"
                class="form-control"
                placeholder="Search"
                @input="onSearch"
              />
            </div>
            <div class="col">
              <select
                v-model="filterBy"
                id="institute"
                class="form-control"
                required
                @change="filterByCollege"
              >
                <option value="" selected disabled>Select college</option>
                <option value="1">CEIS</option>
                <option value="2">CA</option>
                <option value="3">CTE</option>
                <option value="4">CAS</option>
              </select>
            </div>
          </div>
          <table class="table table-hover" style="max-height: 80vh">
            <thead>
              <tr>
                <th scope="col">Status</th>
                <th scope="col">Lastname</th>
                <th scope="col">Firstname</th>
                <th scope="col">Middle Initial</th>
                <th scope="col">Institute</th>
                <th scope="col">Actions</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in instructorList" :key="item.instructor_id">
                <th scope="row">
                  <span
                    :class="
                      item.userStatus === 1
                        ? 'badge bg-success'
                        : 'badge bg-secondary'
                    "
                    >{{ item.userStatus === 1 ? 'Active' : 'Inactive' }}</span
                  >
                </th>
                <td>{{ item.last_name }}</td>
                <td>{{ item.first_name }}</td>
                <td>{{ item.middle_name }}</td>
                <td>{{ item.institute_title }}</td>
                <td>
                  <button
                    @click="onEdit(item.instructor_id)"
                    type="button"
                    class="btn btn-primary btn-sm me-2"
                  >
                    EDIT
                  </button>
                  <button
                    @click="onDelete(item.instructor_id)"
                    type="button"
                    class="btn btn-danger btn-sm"
                  >
                    DELETE
                  </button>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
    <Dashboard />
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';
import Dashboard from '../components/Dashboard.vue';
import InstructorForm from '../components/InstructorForm.vue';

export default {
  name: 'Index',
  data() {
    return {
      isActive: 0,
      instructorList: [],
      info: {},
      operation: 'add',
      search: '',
      filterBy: 0,
      onLoad: false, // set loader to true during fetching
    };
  },
  components: { InstructorForm, Dashboard },
  created() {
    // add your code here..
  },
  methods: {
    ...mapActions({
      fetchInstructors: 'instructor/fetchInstructors',
      addInstructors: 'instructor/addInstructors',
      updateInstructor: 'instructor/updateInstructor',
      deleteInstructor: 'instructor/deleteInstructor',
      fetchReportNumbers: 'report/fetchReportNumbers',
    }),

    async onFetch() {
      this.onLoad = true;
      try {
        await this.fetchReportNumbers();
        await this.fetchInstructors();
        this.instructorList = this.instructor;
      } catch (error) {
        console.log(error);
      }
    },

    filterByCollege() {
     // JavaScript
     // add your code here..
    },

    onEdit(instructor_id) {
      this.operation = 'edit';
      const instructor = this.instructorList.filter(
        (x) => x.instructor_id === instructor_id,
      );
      this.info = instructor[0];
    },

    onSearch() {
      // JavaScript 
      // add your code here..
    },

    async handleSubmit(info) {
      try {
        await this.addInstructors(info);
        this.onFetch();
      } catch (error) {
        console.log(error);
      }
    },

    async handleSave(info) {
      try {
        await this.updateInstructor(info);
        this.onFetch();
      } catch (error) {
        console.log(error);
      }
    },

    async onDelete(id) {
      try {
        await this.deleteInstructor(id);
        this.onFetch();
      } catch (error) {
        console.log(error);
      }
    },
  },
  computed: {
    ...mapState({
      instructor: (state) => state.instructor.instructor,
    }),
  },
};
</script>
