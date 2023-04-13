import http from '../http-common'

class DriverDataService {
    list() {
        return http.get("/driver/all");
    }

    register(driver) {
        return http.post("/driver/", driver);
    }
}

export default new DriverDataService();