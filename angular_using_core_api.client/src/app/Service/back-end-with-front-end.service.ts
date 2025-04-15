import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BackEndWithFrontEndService {

  constructor(private Http: HttpClient) { }

  Get_Categories() {
    return this.Http.get("https://localhost:7148/api/CategoryControllerUsingTierArchitecture/All-Categories");
  }
  Get_Products() {
    return this.Http.get("https://localhost:7148/api/ProductControllerUsingTierArchitecture/AllProducts");
  }
  Get_ProductsBasedOnID(id: any) {
    return this.Http.get(`https://localhost:7148/api/ProductControllerUsingTierArchitecture/OneProductBasedOnID/${id}`);
  }
  Put_Product(id: any, data: any) {
    return this.Http.put(`https://localhost:7148/api/ProductControllerUsingTierArchitecture/EditProduct/${id}`, data);
  } 

  Delete_Product(id: any) {
  return this.Http.delete(`https://localhost:7148/api/ProductControllerUsingTierArchitecture/DeleteOneProductBasedOnID/${id}`);
  }
  Post_Product(data: any) {
    return this.Http.post("https://localhost:7148/api/ProductControllerUsingTierArchitecture/AddNewProduct", data);
  }
  Get_Users() {
    return this.Http.get("https://localhost:7148/api/UserControllerUsingTierArchitecture/AllUsers");
  }

}
