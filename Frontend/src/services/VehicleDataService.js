import http from "../http-common";

class VehicleDataService {
    list() {
        return http.get("/vehicle/all");
    }

    register(vehicle) {
        return http.post("/vehicle/", vehicle);
    }
}

export default new VehicleDataService();