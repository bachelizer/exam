<template>
  <div class="col-md-3">
    <div class="row ms-5">
      <div
        v-for="number in numbers"
        :key="number.institute_title"
        class="col-md-6 mb-2"
      >
        <div class="card">
          <div class="card-body">
            <h4>{{ number.number }}</h4>
            <h6>{{ number.institute_title }}</h6>
            <span style="float: right">{{ number.percent }}%</span>
          </div>
        </div>
      </div>
      <h2 class="mt-5">
        Total active instructor: <strong>{{ totalInstructor }}</strong>
      </h2>
    </div>
  </div>
</template>
<script>
import { mapState, mapActions } from 'vuex';

export default {
  name: 'Dashboard',
  mounted() {
    this.Load();
  },
  methods: {
    ...mapActions({
      fetchReportNumbers: 'report/fetchReportNumbers',
    }),
    Load() {
      this.fetchReportNumbers();
    },
  },
  computed: {
    ...mapState({
      numbers: (state) => state.report.reportNumber,
    }),
    totalInstructor() {
    // JavaScript
    },
  },
};
</script>
