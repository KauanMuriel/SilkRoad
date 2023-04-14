import http from "../http-common";

class BrandDataService {
    list() {
        return http.get("/brand/GetAll");
    }

    register(brand) {
        return http.post("/brand", brand);
    }

    getById(id) {
        return http.get(`/brand/${id}`);
    }
}

export default new BrandDataService();