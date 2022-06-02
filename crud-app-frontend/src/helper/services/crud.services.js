import apiClient from '../apiClient';

const fetchInstructors = () => apiClient.get('/instructor');

const addInstructors = (data) => apiClient.post('/instructor', data);

const updateInstructor = (data) => apiClient.put('/instructor', data);

// add your code here..
// API for deletion of instructor

export default {
  fetchInstructors,
  addInstructors,
  updateInstructor,
};
