<template>
  <div class="card" style="text-align: left;">
    <div class="card-body">
      <form @submit.prevent="handleSubmit(info)" ref="instructorFrom">
        <div class="row">
           <div class="col-auto form-group">
            <label for="designation" class="form-label">Designation</label>
            <input
              v-model="info.designation"
              type="text"
              class="form-control"
              id="designation"
              placeholder="eg. Mr/Mrs/Engr/Dr."
              required
            />
          </div>
          <div class="col-auto form-group">
            <label for="lastname" class="form-label">Last Name</label>
            <input
              v-model="info.last_name"
              type="text"
              class="form-control"
              id="lastname"
              placeholder="lastname"
              required
            />
          </div>
          <div class="col-auto form-group">
            <label for="firstname" class="form-label">First Name</label>
            <input
              v-model="info.first_name"
              type="text"
              class="form-control"
              id="firstname"
              placeholder="firstname"
              required
            />
          </div>
          <div class="col-auto form-group">
            <label for="middlename" class="form-label">Middle Name</label>
            <input
              v-model="info.middle_name"
              type="text"
              class="form-control"
              id="middlename"
              placeholder="middlename"
              required
            />
          </div>
        </div>
        <div class="row mt-3">
          <div class="col-auto form-group">
            <label for="status" class="form-label">Status</label>
             <select
              v-model="info.userStatus"
              id="status"
              class="form-control"
              required
            >
              <option selected disabled>Select Status</option>
              <option value="0">inactive</option>
              <option value="1">active</option>
            </select>
          </div>
          <div class="col-auto form-group">
            <label for="institute" class="form-label">College</label>
            <select
              v-model="info.institute_id"
              id="institute"
              class="form-control"
              required
            >
              <option value="" selected disabled>Select College</option>
              <option value="1">CEIS</option>
              <option value="2">CA</option>
              <option value="3">CTE</option>
              <option value="4">CAS</option>
            </select>
          </div>
        </div>
        <div class="row mt-3">
          <div class="col">
            <button :class="operation === 'add' ? 'btn btn-primary' : 'btn btn-success'">{{ operation === 'add' ? 'ADD' : 'SAVE'}}</button>
          </div>
        </div>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: 'InstructorForm',
  props: {
    info: {
      type: Object,
      default: Object
    },
    operation: {
      type: String,
      default: ''
    }
  },
  methods: {
    handleSubmit(info) {
      this.$emit('form-submit', info)
      this.$refs.instructorFrom.reset();
    }
  }
};
</script>
