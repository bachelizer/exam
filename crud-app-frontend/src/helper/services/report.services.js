import apiClient from "../apiClient";


const fetchReportNumbers = () => apiClient.get('/report')

export default {
    fetchReportNumbers
}