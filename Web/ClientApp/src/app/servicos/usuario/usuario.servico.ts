import { Injectable, Inject } from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { observable, Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";

@Injectable({
    providedIn: "root"
})
export class UsuarioServico {
    private baseURL : string;
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseURL = baseUrl;
    }

    public verificarUsuario(_usuario: Usuario): Observable<Usuario> {
        const headers = new HttpHeaders().set('content-type', 'application/json');
        var body = {
            email: _usuario.email,
            senha:  _usuario.senha
        }

        return this.http.post<Usuario>(this.baseURL + "api/usuario", body, { headers });
    }
}
