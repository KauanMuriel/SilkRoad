import http from '../http-common'

class DriverDataService {
    list() {
        return http.get("/model/all");
    }

    register(model) {
        return http.post("/model/", model);
    }
}

export default new DriverDataService();